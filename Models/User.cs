using System;
using System.Collections;
using System.Collections.Generic;

namespace BlueprintAspergerApi.Models
{
  public class User
  {
    public long Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Mail { get; set; }
    public string Password { get; set; }
    public string Telephone { get; set; }
    // statut uyilisateur patient : p, et consultant c
    public string statut { get; set; }
    public virtual ICollection<Message> MesMessages { get; set; }
  }
}