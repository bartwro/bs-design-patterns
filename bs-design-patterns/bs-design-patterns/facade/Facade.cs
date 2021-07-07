namespace bs_design_patterns.facade
{
    /// <summary>
    /// Facade is built on top of other services
    /// It exposes functionality built on top of more comples classes with one method/endpoint
    /// </summary>
    class Facade: IFacade
    {
        private readonly IService1 _service1;
        private readonly IService2 _service2;

        public Facade(IService1 service1, IService2 service2)
        {
            this._service1 = service1;
            this._service2 = service2;
        }

        public Dto GetPreparedData()
        {
            var res = this._service1.Call();
            return this._service2.Call(res);
        }
    }
}
