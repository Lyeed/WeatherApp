#ifndef __API_H__
#define __API_H__

#include "json.h"
#include "curl.h"
#include "app_main.h"
#include "uib_view1_view.h"

JsonObject *getDataByCityName(const char *);
void citiesList_search(const char *str, uib_view1_view_context *vc);

#endif /* __API_H__ */
