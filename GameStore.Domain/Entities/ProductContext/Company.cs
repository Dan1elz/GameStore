﻿using GameStore.Domain.DTOs.ProductContext.Company;
using System.ComponentModel.DataAnnotations;
using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities.ProductContext
{
    public class Company : BaseEntity
    {
        [MaxLength(255, ErrorMessage = "Name of the company must have at most 255 characters"), Required(ErrorMessage = "Inform the name of the company")]
        public string Name { get; private set; } = string.Empty;
        
        [MaxLength(14, ErrorMessage = "CNPJ must have at most 14 characters"), Required(ErrorMessage = "Inform the CNPJ of the company")]
        public string CNPJ { get; private set; } = string.Empty;
        
        [MaxLength(255, ErrorMessage = "Email must have at most 255 characters")]
        public string? Email { get; private set; }
        
        public virtual ICollection<Product> Products { get; set; }
        
        private Company() : base() { }
        public Company(CreateCompanyDTO company) : base()
        {
            Name = company.Name;
            CNPJ = company.CNPJ;
            Email = company.Email;
        }
        public void Update(UpdateCompanyDTO company)
        {
            Name = company.Name;
            CNPJ = company.CNPJ;
            Email = company.Email;
            base.Update();
        }
    }
}