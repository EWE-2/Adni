﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using Adni.Application.Common.Interfaces;
using Adni.Application.CompanyLists.Queries.ExportCompanies;
using System.Globalization;
using Adni.Application.EmployeesLists.Queries.ExportEmployees;
using Adni.Application.ProspectionList.Queries.ExportProspections;

namespace Adni.Shared.Files
{
    public class CsvFileBuilder : ICsvFileBuilder
    {
        public byte[] BuildCompaniesFile(IEnumerable<CompanyItemRecord> records)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                csvWriter.WriteRecord(records);
            }

            return memoryStream.ToArray();
        }

        public byte[] BuildEmployeesFile(IEnumerable<EmployeeItemRecord> records)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                csvWriter.WriteRecord(records);
            }

            return memoryStream.ToArray();
        }

        public byte[] BuildProspectionsFile(IEnumerable<ProspectionsItemRecord> records)
        {
            using var memoryStream = new MemoryStream();
            using (var streamWriter = new StreamWriter(memoryStream))
            {
                using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                csvWriter.WriteRecord(records);
            }

            return memoryStream.ToArray();
        }
    }
}
