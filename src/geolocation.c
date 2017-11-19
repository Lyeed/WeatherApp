#include "geolocation.h"

void initGeolocation(user_location *user)
{
	user = malloc(sizeof(user_location));
}

void initManager(user_location *user)
{
	location_manager_create(LOCATIONS_METHOD_GPS, &(user->manager));
}

void startManager(user_location *user)
{
	location_manager_start(user->manager);
}

void getLocation(user_location *user)
{
	location_manager_get_location(user->manager, &(user->altitude), &(user->latitude),
			&(user->longitude), &(user->climb), &(user->direction), &(user->speed),
			&(user->level), &(user->horizontal), &(user->vertical), &(user->timestamp));
}

void getLastLocation(user_location *user)
{
	location_manager_get_last_location(user->manager, &(user->altitude), &(user->latitude),
			&(user->longitude), &(user->climb), &(user->direction), &(user->speed),
			&(user->level), &(user->horizontal), &(user->vertical), &(user->timestamp));
}

void stopManager(user_location *user)
{
	location_manager_stop(user->manager);
}

void destroyManager(user_location *user)
{
	location_manager_destroy(user->manager);
	user = NULL;
}
