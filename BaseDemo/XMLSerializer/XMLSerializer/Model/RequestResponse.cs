using System.Collections.Generic;
using System.Xml.Serialization;

namespace XMLSerializer.Model
{
    //XML 根 命名空间
    [XmlRoot(Namespace = "http://xmlSerialization.com/schema/TestDemo", ElementName = "GetMyFeesEstimateResponse", IsNullable = false)]
    public class RequestResponse
    {
        //对应XML中节点名称
        [XmlElement(ElementName = "GetMyFeesEstimateResult")]
        public GetMyFeesEstimateResult getMyFeesEstimateResult;
    }

    public class GetMyFeesEstimateResult
    {
        [XmlElement(ElementName = "FeesEstimateResultList")]
        public FeesEstimateResultList feesEstimateResultList;       
    }

    public class FeesEstimateResultList
    {
        [XmlElement(ElementName = "FeesEstimateResult")]
        public List<FeesEstimateResult> feesEstimateResult;
    }

    public class FeesEstimateResult
    {
        [XmlElement(ElementName = "FeesEstimate")]
        public FeesEstimate feesEstimate;
        [XmlElement(ElementName = "FeesEstimateIdentifier")]
        public FeesEstimateIdentifier feesEstimateIdentifier;
        [XmlElement(ElementName = "Status")]
        public string Status;
    }
    
    public class FeesEstimate
    {
        [XmlElement(ElementName = "TotalFeesEstimate")]
        public TotalFeesEstimate totalFeesEstimate;
    }

    public class TotalFeesEstimate
    {
        [XmlElement(ElementName = "Amount")]
        public decimal Fee;
    }

    public class FeesEstimateIdentifier
    {
        [XmlElement(ElementName = "IdValue")]
        public string SKU;
        [XmlElement(ElementName = "PriceToEstimateFees")]
        public PriceToEstimateFees priceToEstimateFees;
    }

    public class PriceToEstimateFees
    {
        [XmlElement(ElementName = "ListingPrice")]
        public ListingPrice listingPrice;
    }

    public class ListingPrice
    {
        [XmlElement(ElementName = "Amount")]
        public decimal Price;
    }
}
