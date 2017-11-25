#include "api.h"
#include <app_resource_manager.h>

uib_view1_view_context *context;

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

		return parser;
	}
	return NULL;
}

JsonObject *getDataById(const int id)
{
	char url[1024];
	char s_id[10];
	char *res;

	sprintf(s_id, "%d", id);
	strcpy(url, "http://api.openweathermap.org/data/2.5/weather?id=");
	strcat(url, s_id);
	strcat(url, "&APPID=bd22c36ca16eb4ba1837a89775b8eed2");
	res = curl_perform(url);
	dlog_print(DLOG_DEBUG, "URL", "%s", url);

	JsonObject *parser = parse(res);
	free(res);

	return parser;
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
		dlog_print(DLOG_DEBUG, "URL", "%s", url);
		res = curl_perform(url);
		free(url);

		JsonObject *parser = parse(res);
		free(res);

		return parser;
	}
	return NULL;
}

JsonArray *cities_list_init()
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

void cities_list_add_item(void *data)
{
	JsonObject *element = (JsonObject *)data;
	const gchar *name = json_object_get_string_member(element, "name");
	char title[1024];

	struct cities_ItemData *itemData = malloc(sizeof(itemData));
	itemData->name = name;
	itemData->id = json_object_get_int_member(element, "id");
	strcpy(title, name);
	strcat(title, " - ");
	strcat(title, json_object_get_string_member(element, "country"));
	if (elm_list_item_append(context->list3, title, NULL, NULL, NULL, itemData) == NULL) {
		dlog_print(DLOG_ERROR, "IOT", "Cannot append item to list");
	}
	if (!evas_object_visible_get(context->list3))
	{
		dlog_print(DLOG_DEBUG, "IOT", "Showing list");
		elm_list_go(context->list3);
		evas_object_show(context->list3);
	}
}

void cities_thread_fnc(JsonArray *cities, guint index, JsonNode *node, gpointer data)
{
	JsonObject *obj = json_node_get_object(node);
	if (strncmp(json_object_get_string_member(obj, "name"), (char *)data, strlen((char *)data)) == 0)
	{
		ecore_main_loop_thread_safe_call_sync((void * ( *)(void *))cities_list_add_item, obj);
	}
}

void cities_thread_init(void *data, Ecore_Thread *thread)
{
	dlog_print(DLOG_DEBUG, "IOT", "Thread start");
	json_array_foreach_element(cities, cities_thread_fnc, (char *)data);
}

void cities_thread_cancel(void *data, Ecore_Thread *thread)
{
	dlog_print(DLOG_DEBUG, "IOT", "Thread cancel");
}

void cities_thread_end(void *data, Ecore_Thread *thread)
{
	dlog_print(DLOG_DEBUG, "IOT", "Thread end");
}

void cities_list_update(const char *str, uib_view1_view_context *vc)
{
	context = vc;
	if ((strlen(str) >= 2) && (cities != NULL))
	{
		elm_list_clear(context->list3);
		ecore_thread_run(cities_thread_init, cities_thread_end, cities_thread_cancel, elm_object_text_get(context->entry1));
	} else {
		evas_object_hide(vc->list3);
	}
}
