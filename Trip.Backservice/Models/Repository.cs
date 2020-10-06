using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Trips.Backservice.Models
{
    public class Repository
    {

        private List<Trip> myTrips = new List<Trip>
        {
           

            new Trip
            {
                Id = 1,
                Name = "Amsterdam confernce 2020",
                StartDate = new DateTime(2020, 10, 6),
                EndDate =  new DateTime(2020, 10, 8)
            },

            new Trip
            {
                Id = 2,
                Name = "MS Ignite 2020",
                StartDate = new DateTime(2020, 11, 10),
                EndDate =  new DateTime(2020, 11, 14)
            },

             new Trip
             {
                Id = 3,
                Name = "Trip to Prague",
                StartDate = new DateTime(2020, 12, 2),
                EndDate =  new DateTime(2020, 12, 4)
            }

        };

        public List<Trip> GetTrips()
        {
            return myTrips;
        }

        public Trip GetTripById(int id)
        {
            return myTrips.First(t => t.Id == id);


        }

        public void AddTrip(Trip newTrip)
        {
            myTrips.Add(newTrip);
        }

        public void UpdateTrip(Trip tripToUpdate)
        {
            myTrips.Remove(myTrips.First(t => t.Id == tripToUpdate.Id));
            myTrips.Add(tripToUpdate);
        }

        public void RemoveTrip(int id)
        {
            myTrips.Remove(myTrips.First(t => t.Id == id));
        }
     }   
    
}
