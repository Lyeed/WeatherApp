#include "api.h"
#include <app_resource_manager.h>

JsonArray *cities = NULL;

JsonObject *getDataByCityName(const char *city)
{
	char *url = malloc((strlen(city) + strlen("http://api.openweathermap.org/data/2.5/weather?q=&APPID=bd22c36ca16eb4ba1837a89775b8eed2")) * sizeof(char));
	if (url)
	{
		char *res;

		strcpy(url, "http://api.openweathermap.org/data/2.5/weather?q=");
		strcat(url, city);
		strcat(url, "&APPID=bd22c36ca16eb4ba1837a89775b8eed2");
		res = curl_perform(url);
		dlog_print(DLOG_DEBUG, "URL", "%s", url);
		free(url);

		JsonObject *parser = parse(res);
		free(res);

		dlog_print(DLOG_DEBUG, "IOT", "City : %s", json_object_get_string_member(parser, "name"));
		dlog_print(DLOG_DEBUG, "IOT", "Id : %d", json_object_get_int_member(parser, "id"));

		return parser;
	}
	return NULL;
}

JsonObject *getDataByCoord(double lat, double lon)
{
	char s_lat[10];
	char s_lon[10];
	sprintf(s_lat, "%f", lat);
	sprintf(s_lon, "%f", lon);

	char *url = malloc(
	(
		strlen(s_lat) + strlen(s_lon) +
		strlen("api.openweathermap.org/data/2.5/weather?lat=&lon=&APPID=bd22c36ca16eb4ba1837a89775b8eed2")
	) * sizeof(char));

	if (url)
	{
		char *res;

		strcpy(url, "api.openweathermap.org/data/2.5/weather?lat=");
		strcat(url, s_lat);
		strcpy(url, "&lon=");
		strcat(url, s_lon);
		strcat(url, "&APPID=bd22c36ca16eb4ba1837a89775b8eed2");

		res = curl_perform(url);
		free(url);

		JsonObject *parser = parse(res);
		free(res);

		JsonObject *tmp = json_object_get_object_member(parser, "coord");
		dlog_print(DLOG_DEBUG, "IOT", "Lon : %f | Lat : %f", json_object_get_double_member(tmp, "lon"), json_object_get_double_member(tmp, "lat"));

		return parser;
	}
	return NULL;
}

JsonArray *citiesList_init()
{
	GError *error;
	JsonParser *parser = json_parser_new();

	char *file_path = malloc((strlen(app_get_resource_path()) + strlen("city.list.json")) * sizeof(char));
	if (file_path)
	{
		strcpy(file_path, app_get_resource_path());
		strcat(file_path, "city.list.json");
		gboolean result = json_parser_load_from_file(parser, file_path, &error);
		if (result)
		{
			dlog_print(DLOG_DEBUG, "PARSE" ,"File %s opened", file_path);
			free(file_path);

			JsonNode *root = json_parser_get_root(parser);
		    if (json_node_get_node_type(root) == JSON_NODE_NULL || json_node_get_node_type(root) == JSON_NODE_VALUE)
		    {
		        dlog_print(DLOG_ERROR, "PARSE", "not supported root");
		        return NULL;
		    }

		    return json_node_get_array(root);
		} else {
			dlog_print(DLOG_ERROR, "PARSE" ,"Failed to open %s : %s", file_path, error->message);
			free(file_path);
		}
	}

	return NULL;
}

void citiesList_search(const char *str, uib_view1_view_context *vc)
{
	Elm_List *list = vc->list3;
	elm_list_clear(list);

	if (cities == NULL)
	{
		dlog_print(DLOG_DEBUG, "IOT", "Initializing cities list variable");
		cities = citiesList_init();
	}

	if (strlen(str) >= 2)
	{
		if (cities != NULL)
		{
			guint size = json_array_get_length(cities);
			int count = 0;

			for (guint i = 0; i < size; i++)
			{
				JsonObject *obj = json_array_get_object_element(cities, i);
				const gchar *name = json_object_get_string_member(obj, "name");
				if (strncmp(name, str, strlen(str)) == 0)
				{
					const gchar *country = json_object_get_string_member(obj, "country");
					char *title = malloc((strlen(name) + strlen(country) + 4) * sizeof(char));
					if (title)
					{
						strcpy(title, name);
						strcat(title, " - ");
						strcat(title, country);
						if (elm_list_item_append(list, title, NULL, NULL, NULL, json_object_get_string_member(obj, "name")) == NULL)
						{
							dlog_print(DLOG_ERROR, "IOT", "Cannot append item to list");
						} else {
							count++;
						}
						free(title);
					}
				}
			}

			if (count >= 1)
			{
				elm_list_go(list);
				evas_object_show(list);
			} else {
				evas_object_hide(list);
			}
		} else {
			dlog_print(DLOG_ERROR, "IOT", "Cannot initialize cities variable");
			evas_object_hide(list);
		}
	} else {
		evas_object_hide(list);
	}
}
