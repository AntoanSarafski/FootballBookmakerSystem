﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace P02_FootballBetting.Data.Models
{
    public class Position
    {
        public int PositionId { get; set; }

        [Required]
        [MaxLength(Constants.PositionNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
