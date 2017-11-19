#ifndef __JSON_H__
#define __JSON_H__

#include <json-glib/json-glib.h>
#include <glib-object.h>

JsonObject *parse(char *string);

#endif /* __JSON_H__ */
