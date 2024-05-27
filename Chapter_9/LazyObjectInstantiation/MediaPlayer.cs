using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyObjectInstantiation
{
    class MediaPlayer
    {
        // Assume these methods do something useful.
        public void Play() { /* Play a song */ }
        public void Pause() { /* Pause the song */ }
        public void Stop() { /* Stop playback */ }

        //private AllTracks _allSongs = new AllTracks();
        // lazy bazi 
        private Lazy<AllTracks> _allSongs = new Lazy<AllTracks>();
        public AllTracks GetAllTracks()
        {
            // Return all of the songs.
            //return _allSongs;

            // update return for lazy correspondense
            return _allSongs.Value;
        }
    }
}
