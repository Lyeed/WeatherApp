#ifndef __API_H__
#define __API_H__

#include "json.h"
#include "curl.h"
#include "app_main.h"

JsonObject *getDataByCityName(char *city);

#endif /* __API_H__ */
