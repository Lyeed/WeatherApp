/*
 * geolocation.h
 *
 *  Created on: Nov 19, 2017
 *      Author: Julien Luino
 */

#ifndef GEOLOCATION_H_
#define GEOLOCATION_H_

#include <locations.h>
#include <stdlib.h>

typedef struct s_user_location {
	location_manager_h manager;
	double altitude;
	double latitude;
	double longitude;
	double climb;
	double direction;
	double speed;
	double horizontal;
	double vertical;
	location_accuracy_level_e level;
	time_t timestamp;
} user_location;

void initGeolocation(user_location *);
void initManager(user_location *);
void startManager(user_location *);
void getLastLocation(user_location *);
void getLocation(user_location *);
void stopManager(user_location *);
void destroyManager(user_location *);

#endif /* GEOLOCATION_H_ */
