#include "json.h"

JsonObject *parse(char *string)
{
	JsonParser *parser;

	parser = json_parser_new();
	gboolean result = json_parser_load_from_data(parser, string, strlen(string), NULL );
	if (result)
	{
		JsonNode *root = json_parser_get_root(parser);
		return json_node_get_object(root);
	} else {
		dlog_print(DLOG_ERROR, "PARSE" ,"FAILED to PARSE");
	}
	return NULL;
}
