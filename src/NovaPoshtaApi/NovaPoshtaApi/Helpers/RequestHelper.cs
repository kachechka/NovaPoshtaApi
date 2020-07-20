using NovaPoshtaApi.RequestCreators;

namespace NovaPoshtaApi.Helpers
{
    public class RequestHelper
    {
        /// <summary>
        /// Get <see cref="AddressRequestCreator"/> instance 
        /// for creating address requests.
        /// </summary>
        /// <value>Address request creator</value>
        public AddressRequestCreator AddressRequestCreator { get; }

        /// <summary>
        /// Get <see cref="DirectoryRequestCreator"/> instance 
        /// for creating directory requests.
        /// </summary>
        /// <value>Directory request creator</value>
        public DirectoryRequestCreator DirectoryRequestCreator { get; }

        /// <summary>
        /// Get <see cref="ExpressWaybillRequest"/> instance 
        /// for creating express waybill requests.
        /// </summary>
        /// <value>Express waybill request creator</value>
        public ExpressWaybillRequestCreator ExpressWaybillRequest { get; }

        /// <summary>
        /// Get <see cref="RequestCreator"/> instance 
        /// for requests creating.
        /// </summary>
        /// <value>Request creator</value>
        public RequestCreator RequestCreator { get; }

        /// <summary>
        /// Initialize a new instance of the <see cref="RequestHelper"/> class.
        /// </summary>
        public RequestHelper()
        {
            AddressRequestCreator = new AddressRequestCreator();
            DirectoryRequestCreator = new DirectoryRequestCreator();
            ExpressWaybillRequest = new ExpressWaybillRequestCreator();
            RequestCreator = new RequestCreator();
        }
    }


}
