using Nancy.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace BlazorCart.Model
{


    public class tkCalling_hyperPay {



		public Dictionary<string, dynamic> Request()
		{
			Dictionary<string, dynamic> responseData;
			string data = "entityId=8a8294174b7ecb28014b9699220015ca" +
				"&amount=92.00" +
				"&currency=EUR" +
				"&paymentBrand=VISA" +
				"&paymentType=DB" +
				"&card.number=4200000000000000" +
				"&card.holder=Jane Jones" +
				"&card.expiryMonth=05" +
				"&card.expiryYear=2020" +
				"&card.cvv=123";
			string url = "https://test.oppwa.com/v1/payments";
			byte[] buffer = Encoding.ASCII.GetBytes(data);
			HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
			request.Method = "POST";
			request.Headers["Authorization"] = "Bearer OGE4Mjk0MTc0YjdlY2IyODAxNGI5Njk5MjIwMDE1Y2N8c3k2S0pzVDg=";
			request.ContentType = "application/x-www-form-urlencoded";
			Stream PostData = request.GetRequestStream();
			PostData.Write(buffer, 0, buffer.Length);
			PostData.Close();
			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
			{
				Stream dataStream = response.GetResponseStream();
				StreamReader reader = new StreamReader(dataStream);
				var s = new JavaScriptSerializer();
				responseData = s.Deserialize<Dictionary<string, dynamic>>(reader.ReadToEnd());
				reader.Close();
				dataStream.Close();
			}
			return responseData;
		}

		//	responseData = Request()["result"] ["description"];

	}
    public class Result
    {

        public string Code { get; set; }

        public string Description { get; set; }
    }

    public class Card
    {

        public string Bin { get; set; }

        public string Last4Digits { get; set; }

        public string Holder { get; set; }

        public string ExpiryMonth { get; set; }

        public string ExpiryYear { get; set; }
    }

    public class JSONConverter_huperPayMainresponse
    {

        public string Id { get; set; }

        public string PaymentType { get; set; }

        public string PaymentBrand { get; set; }

        public Result Result { get; set; }

        public Card Card { get; set; }

        public string BuildNumber { get; set; }

        public string Timestamp { get; set; }

        public string Ndc { get; set; }
    }
}
