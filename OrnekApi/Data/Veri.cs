﻿namespace OrnekApi.Data
{
    public static class Veri
    {
        public static List<Kisi> Kisiler()
        {
            return new List<Kisi>()
            {
                new Kisi() { Id = 1, Ad = "Sagopa Kajmer" },
                new Kisi() { Id = 2, Ad = "Şebnem Ferah" },
                new Kisi() { Id = 3, Ad = "Messi" },
                new Kisi() { Id = 4, Ad = "Ati" },
                new Kisi() { Id = 5, Ad = "Keanu Reeves" },
                new Kisi() { Id = 6, Ad = "Osimhen" }
            };
        }
    }
}
