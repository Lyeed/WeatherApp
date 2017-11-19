#ifndef __CURL_H__
#define __CURL_H__

#include <curl/curl.h>
#include <net_connection.h>

struct MemoryStruct {
  char *memory;
  size_t size;
};

char *curl_perform(char *url);

#endif /* __CURL_H__ */
