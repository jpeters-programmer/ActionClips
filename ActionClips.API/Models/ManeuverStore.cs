using System.Collections.Generic;

namespace ActionClips.API.Models {
    public class ManeuverStore {
        private readonly List<Maneuver> _maneuvers;

        public ManeuverStore() {
            _maneuvers = new List<Maneuver>();
        }

        public IEnumerable<Maneuver> All => _maneuvers;

        public void Add(Maneuver Maneuver) {
            Maneuver.Id = _maneuvers.Count + 1;
            _maneuvers.Add(Maneuver);
        }
    }
}