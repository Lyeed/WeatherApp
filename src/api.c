#include "api.h"

JsonObject *getDataByCityName(char *city)
{
	char *url = malloc((strlen(city) + strlen("http://api.openweathermap.org/data/2.5/weather?q=&APPID=bd22c36ca16eb4ba1837a89775b8eed2")) * sizeof(char));
	if (url)
	{
		char *res;

		strcpy(url, "http://api.openweathermap.org/data/2.5/weather?q=");
		strcat(url, city);
		strcat(url, "&APPID=bd22c36ca16eb4ba1837a89775b8eed2");
		res = curl_perform(url);
		free(url);

		JsonObject *parser = parse(res);
		free(res);

		dlog_print(DLOG_DEBUG, "IOT", "City : %s", json_object_get_string_member(parser, "name"));
		dlog_print(DLOG_DEBUG, "IOT", "Id : %d", json_object_get_int_member(parser, "id"));
		//get_object_

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
