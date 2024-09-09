﻿using Newtonsoft.Json;

namespace SoundWave.Core
{
    /// <summary>
    /// Класс фильма. 
    /// >>Здесь представлен так называемый Primary конструктор(Доступен с .NET8) 
    /// с необязательным параметром title<<
    /// </summary>
    /// <param name="id">Уникальный идентификатор фильма</param>
    /// <param name="title">Название фильма</param>
    public class Cinema
    {
        public static int _id_counter = 0;
        /// <summary>
        /// Обычный конструктор, до .NET8. В новых версиях доступны оба варианта
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        public Cinema(string title = "Some cinema")
        {
            ItemId = _id_counter++;
            Title = title;
        }

        [JsonProperty("ItemId")]
        public int ItemId { get; set; }

        public string Title { get; set; }


        public override string ToString()
        {
            return ItemId + "|" + Title;
        }
    }
}
