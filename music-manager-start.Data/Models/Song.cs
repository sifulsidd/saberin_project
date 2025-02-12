using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music_manager_starter.Data.Models
{
    public sealed class Song
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }

        //////add a rating to the song
        //public int Rating { get; set; }

        //// this is to determine average ratings with the total divided by number of ratings
        //private double AverageRating;
        //private int TotalRatings;
        //private int NumberOfRatings;

        ////checks whether or not we already rated the song
        ////bool isRated = false;

        ////equals function is there to determine if the song is the same as another song
        //public override bool Equals(object obj)
        //{
        //    if (obj is Song)
        //    {
        //        Song song = obj as Song;
        //        //isRated = true;
        //        return Title.Equals(song.Title) && Artist.Equals(song.Artist) && Album.Equals(song.Album) && Genre.Equals(song.Genre);
        //    }

        //    return false;
        //}

        ////rate song checks if song is rated and if it is, it will add the rating to the total ratings and increment the number of ratings
        ////if it's not rated, we have to set the total ratings to the rating and increment the number of ratings, then find average rating

        //public void RateSong(int rating, object obj)
        //{
        //    if (this.Equals(obj))
        //    {
        //        Song song = obj as Song;
        //        TotalRatings = song.TotalRatings;
        //        NumberOfRatings = song.NumberOfRatings;
        //        TotalRatings += rating;
        //        NumberOfRatings++;
        //        AverageRating = TotalRatings / (NumberOfRatings * 1.0);
        //    }
        //    else
        //    {
        //        TotalRatings = rating;
        //        NumberOfRatings = 1;
        //        AverageRating = TotalRatings / (NumberOfRatings * 1.0);
        //    }
        //}

        ////average rating will be displayed for each song in the song list
        //public double GetAverageRating()
        //{
        //    return AverageRating;
        //}
    }
}
