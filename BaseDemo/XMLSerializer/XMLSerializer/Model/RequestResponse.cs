using System.Collections.Generic;
using System.Xml.Serialization;

namespace XMLSerializer.Model
{
    //XML 根 命名空间
    [XmlRoot(Namespace = "http://xmlSerialization.com/schema/TestDemo", ElementName = "GetResponse", IsNullable = false)]
    public class RequestResponse
    {
        //对应XML中节点名称
        [XmlElement(ElementName = "GetMyResult")]
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
        public string Status;                           //需要
    }
    
    public class FeesEstimate
    {
        [XmlElement(ElementName = "TotalFeesEstimate")]
        public TotalFeesEstimate totalFeesEstimate;
    }

    public class TotalFeesEstimate
    {
        [XmlElement(ElementName = "Amount")]
        public decimal Fee;                             //需要
    }

    public class FeesEstimateIdentifier
    {
        [XmlElement(ElementName = "IdValue")]
        public string SKU;                              //需要
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
        public decimal Price;                           //需要
    }
}
