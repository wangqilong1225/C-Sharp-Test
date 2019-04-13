using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using XMLSerializer.Model;

namespace XMLSerializer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string xml = "<GetMyFeesEstimateResponse xmlns=\"http://xmlSerialization.com/schema/TestDemo\"><GetMyFeesEstimateResult><FeesEstimateResultList><FeesEstimateResult><FeesEstimate><TotalFeesEstimate><CurrencyCode>RMB</CurrencyCode><Amount>29.96</Amount></TotalFeesEstimate></FeesEstimate><FeesEstimateIdentifier><IdValue>ZZ12345</IdValue><PriceToEstimateFees><ListingPrice><CurrencyCode>RMB</CurrencyCode><Amount>499.37</Amount></ListingPrice><Shipping><CurrencyCode>RMB</CurrencyCode><Amount>0</Amount></Shipping></PriceToEstimateFees></FeesEstimateIdentifier><Status>Success</Status></FeesEstimateResult></FeesEstimateResultList></GetMyFeesEstimateResult></GetMyFeesEstimateResponse>";         
            RequestResponse RequestResponse= DeserializeXml(typeof(RequestResponse), xml) as RequestResponse;

            //将XML数据放到ResponseModel中
            ResponseModel responseModel = new ResponseModel();
            responseModel.Status = RequestResponse.getMyFeesEstimateResult.feesEstimateResultList.feesEstimateResult[0].Status;
            responseModel.SKU = RequestResponse.getMyFeesEstimateResult.feesEstimateResultList.feesEstimateResult[0].feesEstimateIdentifier.SKU;
            responseModel.Fee = RequestResponse.getMyFeesEstimateResult.feesEstimateResultList.feesEstimateResult[0].feesEstimate.totalFeesEstimate.Fee;
            responseModel.Price = RequestResponse.getMyFeesEstimateResult.feesEstimateResultList.feesEstimateResult[0].feesEstimateIdentifier.priceToEstimateFees.listingPrice.Price;

            responseModel.ToWriteLineString();
            Console.ReadKey();
        }
        
        //反序列化
        public static object DeserializeXml(Type type, string xml)
        {
            using (StringReader sr = new StringReader(xml))
            {
                XmlSerializer desXml = new XmlSerializer(type);
                return desXml.Deserialize(sr);
            }
        }

    }
}
