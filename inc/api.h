#ifndef __API_H__
#define __API_H__

#include "json.h"
#include "curl.h"
#include "app_main.h"
#include "uib_view1_view.h"

JsonArray *cities;
int city_id;

JsonArray *cities_list_init();
JsonObject *getDataByCityName(const char *);
JsonObject *getDataById(const int id);
JsonObject *getDataByCoord(double lat, double lon);
void cities_list_update(const char *str, uib_view1_view_context *vc);

struct cities_ItemData {
	const gchar *name;
	int id;
};

#endif /* __API_H__ */
