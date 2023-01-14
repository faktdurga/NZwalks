﻿namespace NZWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionID { get; set; }
        public Guid WalksDifficultyID { get; set; }

        // Navigation properties
        public Region Region { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }

    }
}
