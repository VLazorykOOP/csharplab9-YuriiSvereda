using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_10CharpT
{
    internal class MusicCatalog
    {
        Hashtable catalog = new Hashtable();

        public void AddDisk(string diskName)
        {
            catalog[diskName] = new Hashtable();
        }

        public void RemoveDisk(string diskName)
        {
            catalog.Remove(diskName);
        }

        public void AddSong(string diskName, string artist, string songTitle)
        {
            if (catalog.ContainsKey(diskName))
            {
                Hashtable disk = (Hashtable)catalog[diskName];
                if (!disk.ContainsKey(artist))
                {
                    disk[artist] = new ArrayList();
                }
                ArrayList songs = (ArrayList)disk[artist];
                songs.Add(songTitle);
            }
            else
            {
                Console.WriteLine("Disk not found.");
            }
        }

        public void RemoveSong(string diskName, string artist, string songTitle)
        {
            if (catalog.ContainsKey(diskName))
            {
                Hashtable disk = (Hashtable)catalog[diskName];
                if (disk.ContainsKey(artist))
                {
                    ArrayList songs = (ArrayList)disk[artist];
                    songs.Remove(songTitle);
                }
                else
                {
                    Console.WriteLine("Artist not found.");
                }
            }
            else
            {
                Console.WriteLine("Disk not found.");
            }
        }

        public void DisplayCatalog()
        {
            foreach (string diskName in catalog.Keys)
            {
                Console.WriteLine("Disk: " + diskName);
                Hashtable disk = (Hashtable)catalog[diskName];
                foreach (string artist in disk.Keys)
                {
                    Console.WriteLine("  Artist: " + artist);
                    ArrayList songs = (ArrayList)disk[artist];
                    foreach (string songTitle in songs)
                    {
                        Console.WriteLine("    Song: " + songTitle);
                    }
                }
            }
        }

        public void SearchByArtist(string artist)
        {
            foreach (string diskName in catalog.Keys)
            {
                Hashtable disk = (Hashtable)catalog[diskName];
                if (disk.ContainsKey(artist))
                {
                    ArrayList songs = (ArrayList)disk[artist];
                    Console.WriteLine("Disk: " + diskName);
                    Console.WriteLine("  Artist: " + artist);
                    foreach (string songTitle in songs)
                    {
                        Console.WriteLine("    Song: " + songTitle);
                    }
                }
            }
        }
    }
}
