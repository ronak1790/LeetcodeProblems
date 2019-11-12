using System;
namespace LeetcodeProblems {



    public class Song {
        private string name;
        public Song NextSong { get; set; }

        public Song(string name) {
            this.name = name;
        }

        public Song() {
        }

        public void SetNextSong(Song nextSong) {
            this.NextSong = nextSong;
        }


        public bool IsRepeatingPlaylist() {
            Song first = this.NextSong;
            Song last = first == null ? null : first.NextSong;
            string firstName = first.name;
            string lastName = last.name;

            while (last != null) {

                firstName = first.name;
                lastName = last.name;
                if (first == this || first == last)
                    return true;

                if (last != null) {
                    last = last.NextSong;
                }


            }
            return false;
            //throw new InvalidOperationException("Waiting to be implemented.");
        }


        public void Main() {
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");
            Song third = new Song("Third Song");

            first.SetNextSong(second);
            //second.SetNextSong(first);
            second.SetNextSong(third);





            Console.WriteLine(first.IsRepeatingPlaylist());
        }
    }
}
