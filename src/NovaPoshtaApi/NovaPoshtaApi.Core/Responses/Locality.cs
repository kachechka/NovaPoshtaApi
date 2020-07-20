using System.Collections.Generic;
using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="LocalityRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{Description}")]
#endif
    public class Locality
    {
        /// <summary>
        /// <see cref="Ref"/> property.
        /// </summary>
        /// <value>
        /// Идентификатор адреса.
        /// </value>
        public string? Ref { get; set; }

        /// <summary>
        /// <see cref="SettlementType"/> property.
        /// </summary>
        /// <value>
        /// Тип населенного пункта (Село, ПГТ и т.д.).
        /// </value>
        public string? SettlementType { get; set; }

        /// <summary>
        /// <see cref="Latitude"/> property.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMENT
        public string? Latitude { get; set; }

        /// <summary>
        /// <see cref="Longitude"/> property.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMENT
        public string? Longitude { get; set; }

        /// <summary>
        /// <see cref="Description"/> property.
        /// </summary>
        /// <value>
        /// Адрес на Украинском языке.
        /// </value>
        public string? Description { get; set; }

        /// <summary>
        /// <see cref="DescriptionRu"/> property.
        /// </summary>
        /// <value>
        /// Адрес на русском языке.
        /// </value>
        public string? DescriptionRu { get; set; }

        /// <summary>
        /// <see cref="SettlementTypeDescription"/> property.
        /// </summary>
        /// <value>
        /// Тип населённого пункта.
        /// </value>
        public string? SettlementTypeDescription { get; set; }

        /// <summary>
        /// <see cref="SettlementTypeDescriptionRu"/> property.
        /// </summary>
        /// <value>
        /// Тип населённого пункта.
        /// </value>
        public string? SettlementTypeDescriptionRu { get; set; }

        /// <summary>
        /// <see cref="Region"/> property.
        /// </summary>
        /// <value>
        /// Код населенного пункта.
        /// </value>
        public string? Region { get; set; }

        /// <summary>
        /// <see cref="RegionsDescription"/> property.
        /// </summary>
        /// <value>
        /// Область.
        /// </value>
        public string? RegionsDescription { get; set; }

        /// <summary>
        /// <see cref="RegionsDescriptionRu"/> property.
        /// </summary>
        /// <value>
        /// Область.
        /// </value>
        public string? RegionsDescriptionRu { get; set; }

        /// <summary>
        /// <see cref="Area"/> property.
        /// </summary>
        /// <value>
        /// Область.
        /// </value>
        public string? Area { get; set; }

        /// <summary>
        /// <see cref="AreaDescription"/> property.
        /// </summary>
        /// <value>
        /// Обозначение области на Украинском языке.
        /// </value>
        public string? AreaDescription { get; set; }

        /// <summary>
        /// <see cref="AreaDescriptionRu"/> property.
        /// </summary>
        /// <value>
        /// Обозначение области на Русском языке.
        /// </value>
        public string? AreaDescriptionRu { get; set; }

        /// <summary>
        /// <see cref="Index1"/> property.
        /// </summary>
        /// <value>
        /// Индекс.
        /// </value>
        public string? Index1 { get; set; }

        /// <summary>
        /// <see cref="Index2"/> property.
        /// </summary>
        /// <value>
        /// Индекс.
        /// </value>
        public string? Index2 { get; set; }

        /// <summary>
        /// <see cref="IndexCOATSU1"/> property.
        /// </summary>
        /// <value>
        /// Диапазон индексов КОАТУУ.
        /// </value>
        public string? IndexCOATSU1 { get; set; }

        /// <summary>
        /// <see cref="Delivery1"/> property.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в днях недели (понедельник).
        /// </value>
        public string? Delivery1 { get; set; }

        /// <summary>
        /// <see cref="Delivery2"/> property.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в днях недели (вторник).
        /// </value>
        public string? Delivery2 { get; set; }

        /// <summary>
        /// <see cref="Delivery3"/> property.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в днях недели (среда).
        /// </value>
        public string? Delivery3 { get; set; }

        /// <summary>
        /// <see cref="Delivery4"/> property.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в днях недели (четверг).
        /// </value>
        public string? Delivery4 { get; set; }

        /// <summary>
        /// <see cref="Delivery5"/> property.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в днях недели (пятница).
        /// </value>
        public string? Delivery5 { get; set; }

        /// <summary>
        /// <see cref="Delivery6"/> property.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в днях недели (суббота).
        /// </value>
        public string? Delivery6 { get; set; }

        /// <summary>
        /// <see cref="Delivery7"/> property.
        /// </summary>
        /// <value>
        /// Наличие доставки отправления в днях недели (воскренье).
        /// </value>
        public string? Delivery7 { get; set; }

        /// <summary>
        /// <see cref="Warehouse"/> property
        /// </summary>
        /// <value>
        /// Наличие отделений
        /// </value>
        public string? Warehouse { get; set; }

        /// <summary>
        /// <see cref="Conglomerates"/> property
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMENT
        public List<string>? Conglomerates { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="Locality"/>
        /// </summary>
        public Locality()
        { }
    }
}
