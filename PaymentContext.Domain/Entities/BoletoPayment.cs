using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities;

public class BoletoPayment : Payment
{
    public BoletoPayment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer,
        Document document, Address address, Email email, string barcode, string boletoNumber) : base(paidDate, expireDate,
        total, totalPaid, payer, document, address, email)
    {
        Barcode = barcode;
        BoletoNumber = boletoNumber;
    }

    public string Barcode { get; private set; }
    public string BoletoNumber { get; private set; }
}