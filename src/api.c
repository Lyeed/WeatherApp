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
		dlog_print(DLOG_DEBUG, "URL", "%s", url);
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
