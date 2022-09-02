using System;
using System.Collections.Generic;

namespace Adni.Domain.Entities //A REVOIR ENTIEREMENT
{
    /**
     * <summary> Classe <c>Intership</c> est une classe de mise en stage ayant
     * </summary>
     */
    public class Internship
    {
        public Guid InternshipId { get; set; }
        /// <summary>
        /// Identifiant de la mise en stage concernee
        /// </summary>
        public Guid InternshipPlacementId { get; set; }
        /// <summary>
        /// <code>IsActive</code> defini si le stage est encours ou non
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// Individuel ou groupe
        /// </summary>
        public string IntershipType { get; set; }
    }
}
