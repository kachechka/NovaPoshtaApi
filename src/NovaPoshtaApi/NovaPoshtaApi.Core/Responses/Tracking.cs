using System.Collections.Generic;
using System.Diagnostics;
using NovaPoshtaApi.Core.Requests;

namespace NovaPoshtaApi.Core.Responses
{
    /// <summary>
    /// Ответ на запрос <see cref="TrackingRequest"/>.
    /// </summary>
#if DEBUG
    [DebuggerDisplay("{Number} - {Status}")]
#endif
    public class Tracking
    {
        /// <summary>
        /// Get or set document number.
        /// </summary>
        /// <value>
        /// Номер ЭН.
        /// </value>
        public string? Number { get; set; }

        /// <summary>
        /// Get or set is redelivery.
        /// </summary>
        /// <value>
        /// Идентификатор обратной доставки. 0 - нет ОД 1 - есть ОД.
        /// </value>
        public string? Redelivery { get; set; }

        /// <summary>
        /// Get or set redelivery sum.
        /// </summary>
        /// <value>
        /// Сумма обратной доставки.
        /// </value>
        public string? RedeliverySum { get; set; }

        /// <summary>
        /// Get or set redelivery number.
        /// </summary>
        /// <value>
        /// Идентификатор номера ЭН обратной доствки.
        /// </value>
        public string? RedeliveryNum { get; set; }

        /// <summary>
        /// Get or set redelivery payer.
        /// </summary>
        /// <value>
        /// Идентификатор плательщика обратной доставки.
        /// </value>
        public string? RedeliveryPayer { get; set; }

        /// <summary>
        /// Get or set owner document type.
        /// </summary>
        /// <value>
        /// Тип ЭН на основании.
        /// </value>
        public string? OwnerDocumentType { get; set; }

        /// <summary>
        /// Get or set last created on basic document type.
        /// </summary>
        /// <value>
        /// Последние изменения, тип документа.
        /// </value>
        public string? LastCreatedOnTheBasisDocumentType { get; set; }

        /// <summary>
        /// Get or set last created on basic payer type.
        /// </summary>
        /// <value>
        /// Последние изменения, тип плательщика.
        /// </value>
        public string? LastCreatedOnTheBasisPayerType { get; set; }

        /// <summary>
        /// Get or set last created on basic date time.
        /// </summary>
        /// <value>
        /// Последние изменения, дата создания.
        /// </value>
        public string? LastCreatedOnTheBasisDateTime { get; set; }

        /// <summary>
        /// Get or set last last transaction status.
        /// </summary>
        /// <value>
        /// Последний статус транзакции денежного перевода.
        /// </value>
        public string? LastTransactionStatusGM { get; set; }

        /// <summary>
        /// Get or set last last transaction time.
        /// </summary>
        /// <value>
        /// Последнее время и дата транзакции денежного перевода.
        /// </value>
        public string? LastTransactionDateTimeGM { get; set; }

        /// <summary>
        /// Get or set create date.
        /// </summary>
        /// <value>
        /// Дата создания ЭН
        /// </value>
        public string? DateCreated { get; set; }

        /// <summary>
        /// Get or set document weight.
        /// </summary>
        /// <value>
        /// Вес
        /// </value>
        public string? DocumentWeight { get; set; }

        /// <summary>
        /// Get or set information after check weight.
        /// </summary>
        /// <value>
        /// Информация после контрольного взвешивания.
        /// </value>
        public string? CheckWeight { get; set; }

        /// <summary>
        /// Get or set document cost.
        /// </summary>
        /// <value>
        /// Стоимость доставки.
        /// </value>
        public string? DocumentCost { get; set; }

        /// <summary>
        /// Get or set information before check weight.
        /// </summary>
        /// <value>
        /// Информация до контрольного взвешивания.
        /// </value>
        public string? SumBeforeCheckWeight { get; set; }

        /// <summary>
        /// Get or set payer type ref.
        /// </summary>
        /// <value>
        /// Идентификатор плательщика.
        /// </value>
        public string? PayerType { get; set; }

        /// <summary>
        /// Get or set recipient full name.
        /// </summary>
        /// <value>
        /// Данные ФИО получателя с накладной (при вводе телефона).
        /// </value>
        public string? RecipientFullName { get; set; }

        /// <summary>
        /// Get or set recipient date time.
        /// </summary>
        /// <value>
        /// Дата, когда груз забрал получатель.
        /// </value>
        public string? RecipientDateTime { get; set; }

        /// <summary>
        /// Get or set expected delivery date.
        /// </summary>
        /// <value>
        /// Ожидаемая дата доставки.
        /// </value>
        public string? ScheduledDeliveryDate { get; set; }

        /// <summary>
        /// Get or set payment type.
        /// </summary>
        /// <value>
        /// Способ оплаты.
        /// </value>
        public string? PaymentMethod { get; set; }

        /// <summary>
        /// Get or set cargo description.
        /// </summary>
        /// <value>
        /// Описание посылки.
        /// </value>
        public string? CargoDescriptionString { get; set; }

        /// <summary>
        /// Get or set cargo type.
        /// </summary>
        /// <value>
        /// Тип груза.
        /// </value>
        public string? CargoType { get; set; }

        /// <summary>
        /// Get or set sender city.
        /// </summary>
        /// <value>
        /// Город отправителя.
        /// </value>
        public string? CitySender { get; set; }

        /// <summary>
        /// Get or set recipient city.
        /// </summary>
        /// <value>
        /// Город получателя.
        /// </value>
        public string? CityRecipient { get; set; }

        /// <summary>
        /// Get or set recipient warehouse.
        /// </summary>
        /// <value>
        /// Склад получателя.
        /// </value>
        public string? WarehouseRecipient { get; set; }

        /// <summary>
        /// Get or set counterparty type ref.
        /// </summary>
        /// <value>
        /// Идентификатор.
        /// </value>
        public string? CounterpartyType { get; set; }

        /// <summary>
        /// Get or set afterpayment on goods cost.
        /// </summary>
        /// <value>
        /// Контроль Оплаты.
        /// </value>
        public string? AfterpaymentOnGoodsCost { get; set; }

        /// <summary>
        /// Get or set delivery type ref.
        /// </summary>
        /// <value>
        /// Идентификатор способа доставки.
        /// </value>
        public string? ServiceType { get; set; }

        /// <summary>
        /// Get or set undelivery reasons description.
        /// </summary>
        /// <value>
        /// Описание причины неразвоза.
        /// </value>
        public string? UndeliveryReasonsSubtypeDescription { get; set; }

        /// <summary>
        /// Get or set recipient department number.
        /// </summary>
        /// <value>
        /// Номер отделения получателя.
        /// </value>
        public string? WarehouseRecipientNumber { get; set; }

        /// <summary>
        /// Get or set last changes on the basis number.
        /// </summary>
        /// <value>
        /// Последние изменения, номер ЭН.
        /// </value>
        public string? LastCreatedOnTheBasisNumber { get; set; }

        /// <summary>
        /// Get or set recipient phone.
        /// </summary>
        /// <value>
        /// Телефон получателя.
        /// </value>
        public string? PhoneRecipient { get; set; }

        /// <summary>
        /// Get or set recipient full name.
        /// </summary>
        /// <value>
        /// Данные ФИО получателя с накладной (при вводе телефона).
        /// </value>
        public string? RecipientFullNameEW { get; set; }

        /// <summary>
        /// Get or set recipient warehouse ref.
        /// </summary>
        /// <value>
        /// Идентификатор склада получателя.
        /// </value>
        public string? WarehouseRecipientInternetAddressRef { get; set; }

        /// <summary>
        /// Get or set marketplace partner token.
        /// </summary>
        /// <value>
        /// 
        /// </value>
        // MISSING_COMMNENT
        public string? MarketplacePartnerToken { get; set; }

        /// <summary>
        /// Get or set client barcode.
        /// </summary>
        /// <value>
        /// Внутренний номер заказа.
        /// </value>
        public string? ClientBarcode { get; set; }

        /// <summary>
        /// Get or set recipient address.
        /// </summary>
        /// <value>
        /// Адрес получателя.
        /// </value>
        public string? RecipientAddress { get; set; }

        /// <summary>
        /// Get or set recipient counterparty description.
        /// </summary>
        /// <value>
        /// Описание контрагента получателя.
        /// </value>
        public string? CounterpartyRecipientDescription { get; set; }

        /// <summary>
        /// Get or set sender counterparty type.
        /// </summary>
        /// <value>
        /// Тип контрагента отправителя.
        /// </value>
        public string? CounterpartySenderType { get; set; }

        /// <summary>
        /// Get or set scaning date.
        /// </summary>
        /// <value>
        /// Дата сканировки, которая привела к формированию статуса.
        /// </value>
        public string? DateScan { get; set; }

        /// <summary>
        /// Get or set payment status.
        /// </summary>
        /// <value>
        /// Статус для интернет эквайринг.
        /// </value>
        public string? PaymentStatus { get; set; }

        /// <summary>
        /// Get or set payment date.
        /// </summary>
        /// <value>
        /// Дата оплаты для интернет эквайринг.
        /// </value>
        public string? PaymentStatusDate { get; set; }

        /// <summary>
        /// Get or set amount to pay.
        /// </summary>
        /// <value>
        /// Сумма к оплате для интернет эквайринг.
        /// </value>
        public string? AmountToPay { get; set; }

        /// <summary>
        /// Get or set amount paind.
        /// </summary>
        /// <value>
        /// Оплачено для интернет эквайринг.
        /// </value>
        public string? AmountPaid { get; set; }

        /// <summary>
        /// Get or set status.
        /// </summary>
        /// <value>
        /// Статус.
        /// </value>
        public string? Status { get; set; }

        /// <summary>
        /// Get or set status code.
        /// </summary>
        /// <value>
        /// Идентификатор статуса.
        /// </value>
        public string? StatusCode { get; set; }

        /// <summary>
        /// Get or set waybill ref.
        /// </summary>
        /// <value>
        /// Идентификатор накладной для эквайринга (используется в рабочих целях).
        /// </value>
        public string? RefEW { get; set; }

        /// <summary>
        /// Get or set backward delivery sub types services.
        /// </summary>
        /// <value>
        /// Информация по не стандартным подтипам обратной доставки.
        /// </value>
        public List<object>? BackwardDeliverySubTypesServices { get; set; }

        /// <summary>
        /// Get or set backward delivery sub types actions.
        /// </summary>
        /// <value>
        /// Информация по не стандартным подтипам обратной доставки.
        /// </value>
        public List<object>? BackwardDeliverySubTypesActions { get; set; }

        /// <summary>
        /// Get or set undelivery reason.
        /// </summary>
        /// <value>
        /// Причина неразвоза.
        /// </value>
        public string? UndeliveryReasons { get; set; }

        /// <summary>
        /// Initialize a new instance of the <see cref="TimeInterval"/> class.
        /// </summary>
        public Tracking()
        { }
    }
}
