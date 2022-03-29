using Delegate_task.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_task.Models
{
    internal class Pharmacy
    {
        public int MedicineLimit { get; set; }
        private List<Medicine> _MedicineList;
        public Pharmacy(int MedicineLimit)
        {
            _MedicineList = new List<Medicine>();
            this.MedicineLimit = MedicineLimit;
        }
        public void AddMedicine(Medicine medicine)
        {
            if (medicine == null)
            {
                throw new MedicineAlreadyExistsException("Bu obyekt artiq var");
            }
            if (_MedicineList.Count > MedicineLimit)
            {
                throw new CapacityLimitException("Limiti kecir");
            }
        }
        public bool IsDeleted { get; set; } = false;
        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> medicineCopy = new List<Medicine>();
            medicineCopy.AddRange(_MedicineList);

            return medicineCopy;
        }

        public List<Medicine> FilterMedicinesByPrice(double minPrice, double maxPrice)
        {
            return _MedicineList.FindAll(medicine => medicine.Price >= minPrice && medicine.Price <= maxPrice);

        }
        public Medicine GetMedicineById(int? id)
        {
            if (id == null)
                throw new NullReferenceException("id null olmur");
            Medicine medicine = _MedicineList.Find(medicine => medicine.Id == id && medicine.IsDeleted);
            return medicine;
        }
        public void DeleteMedicineById(int? id)
        {
            if (id==null)
                throw new NullReferenceException("id null olmayacag");
                
            Medicine medicine=_MedicineList.Find(medicine => medicine.Id == id && medicine.IsDeleted);

            if (medicine != null)
                throw new NotFoundException("tapilmadi");
            _MedicineList.Remove(medicine);

            if (medicine == null)
                throw new NotFoundException("Tapildi");
            IsDeleted = true;
            Medicine medici = _MedicineList.Find(medicine => medicine.medicinee == id && medicine.IsDeleted);
            _MedicineList.Add(medicine); 
            

        }
        public void EditMedicineEmail(int?id, string name)
        {
            if (id==null || string.IsNullOrEmpty(name))
            {
                throw new NullReferenceException("Id ve Name null ola bilmir");
            }
            Medicine medicine = _MedicineList.Find(medicine => medicine.Id == id && medicine.IsDeleted);
            if (medicine == null)
            {
                throw new NotFoundException("Medicine obyekti tapilmadi");
            }
            medicine.Name= name;
        }
    }
}
