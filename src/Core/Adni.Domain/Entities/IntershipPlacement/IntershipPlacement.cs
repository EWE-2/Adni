using System;
using System.Collections.Generic;
using System.Text;

namespace Adni.Domain.Entities
{
    public class InternshipPlacement
    {
        public Guid InternshipPlacementId { get; set; }
        ///<summary>
        ///Type de stage
        ///</summary>
        public string InternType { get; set; }
        ///<summary>
        ///Entreprise consernee
        ///</summary>
        public Guid CompanyId { get; set; }

        ///<summary>
        ///<c>IsSend</c> est True si le document a ete recupere par les etudiants
        ///</summary>
        public bool IsSend { get; set; }
        ///<summary>
        ///<c>IsCompleted</c> est <code>True</code> si les places ne sont plus disponibles pour une entreprise
        ///</summary>
        public bool IsCompleted { get; set; }
        ///<summary>
        ///Id du document de mise en stage
        ///</summary>
        public Guid IntershipDcm { get; set; }
        ///<summary>
        ///Etudiant concernee par la mise en stage
        ///</summary>
        public IList<Student>? Students { get; set; } 
    }
}
