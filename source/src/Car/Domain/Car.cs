namespace CarRent.Car.Domain
{
    using CarRent.Car.Api.v1;
    using CarRent.Common.Domain;

    public class Car : Entity, IAggregateRoot
    {
        private CarResponseDto carResponseDto;

        public Car(CarResponseDto carResponseDto)
        {
            this.carResponseDto = carResponseDto;
        }

        public string CarNumber { get; }

        public CarClass CarClass { get; }

        public Brand Brand { get; }

        public Type Type { get; }
    }
}
