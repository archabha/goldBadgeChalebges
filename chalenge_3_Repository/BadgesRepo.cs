using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chalenge_3_Repository
{
    public class BadgesRepo
    {
        private Dictionary<int, Badges> _BadgeDictionary = new Dictionary<int, Badges>()
        private List<string> _Doors = new List<string>() { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8" };
        private Badges newBadge;
        private object doorsAdded;
        private int key;
        private readonly object badgeKey;

        // Create
        public void CreateNewBadge(int newKey, Badges newBadges)
        {
            _BadgeDictionary.Add(newKey, newBadge);

        }
        
        // Read
        public Dictionary<int, Badges> DisplayListOfBadges()
        {
            return _BadgeDictionary;
        }
        public List<string> ListeOfDoors()
        {
            return _Doors;
        }

        // Update
        public void AddDoorsToBadge(int key, List<string> doorsAdded)
        {
            var badgeToUpdate = GetBadgeByKey(key);
            badgeToUpdate.HasAccessTo.AddRange(doorsAdded);   // = updateBadge.HasAccessTo;
        }

        private object GetBadgeByKey(int key)
        {
            throw new NotImplementedException();
        }
        public void RemoveDoorsFromBadge(int key, List<string> doorsRemoved)
        {
            var badgeToUpdate = GetBadgeByKey( key);
            badgeToUpdate.HasAccessTo.AddRange(doorsAdded);   // = updatedBadge.HasAccessTo;

        }

        public void RemoveDoorsFromBadge(int Key, List<string> doorsRemoved)
        {
            var badgeToUpdate = GetBadgeByKey( key);
            badgeToUpdate.HasAccessTo = badgeToUpdate.HasAccessTo.Except(doorsRemoved).ToList(); 
        }

        private object GetBadgeByKey(object key)
        {
            throw new NotImplementedException();
        }
        public void DeactivateBadge(int key)
        {

            var badgeToUpdate = GetBadgeByKey( key);
            badgeToUpdate.EmployeeName = "DEACTIVATED";
            badgeToUpdate.HasAccessTo.Clear();

        }
        // Delate
        // See deactivated method

        // Helper Method
        public Badges GetBadgeByKey(int key)
        {
            foreach (KeyValuePair<int.Parse Badges badgeKey in _BadgeDictionary>)
            {
                if (GetBadgeByKey.Key == key)
                {
                    return GetBadgeByKey.Value; // if match is found
                }
            }
            return null; // will only come to null if the key was not found
        }
    }
}
