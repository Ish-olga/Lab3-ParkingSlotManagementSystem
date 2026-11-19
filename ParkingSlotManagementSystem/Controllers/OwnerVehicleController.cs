
using System.Collections.Generic;
using ParkingSlotManagementSystem.Data;
using ParkingSlotManagementSystem.Models;

namespace ParkingSlotManagementSystem.Controllers
{
    public class OwnerVehicleController
    {
        private readonly OwnerRepository ownerRepository;
        private readonly VehicleRepository vehicleRepository;

        public OwnerVehicleController()
        {
            ownerRepository = new OwnerRepository();
            vehicleRepository = new VehicleRepository();
        }

        // Add a vehicle owner
        public void AddOwner(Owner owner)
        {
            ownerRepository.AddOwner(owner);
        }

        // Retrieve all owners
        public List<Owner> GetAllOwners()
        {
            return ownerRepository.GetAllOwners();
        }

        // Update owner details
        public void UpdateOwner(Owner owner)
        {
            ownerRepository.UpdateOwner(owner);
        }

        // Delete an owner
        public void DeleteOwner(int ownerId)
        {
            ownerRepository.DeleteOwner(ownerId);
        }

        // Add a vehicle
        public void AddVehicle(Vehicle vehicle)
        {
            vehicleRepository.AddVehicle(vehicle);
        }

        // Retrieve all vehicles
        public List<Vehicle> GetAllVehicles()
        {
            return vehicleRepository.GetAllVehicles();
        }

        // Search vehicle by plate number
        public Vehicle? SearchVehicle(string plateNumber)
        {
            return vehicleRepository.SearchByPlate(plateNumber);
        }

        // Update vehicle details
        public void UpdateVehicle(Vehicle vehicle)
        {
            vehicleRepository.UpdateVehicle(vehicle);
        }

        // Delete a vehicle
        public void DeleteVehicle(int vehicleId)
        {
            vehicleRepository.DeleteVehicle(vehicleId);
        }
    }
}


