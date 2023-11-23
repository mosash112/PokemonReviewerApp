﻿namespace PokemonReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }

        public String  Title { get; set; }

        public String Text { get; set; }

        public Reviewer Reviewer { get; set; }

        public Pokemon Pokemon { get; set; }
    }
}
