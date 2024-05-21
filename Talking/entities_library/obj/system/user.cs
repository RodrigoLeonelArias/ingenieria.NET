namespace entities_library.system;

public class User
{  
  private long id

  private image avatar

  public void SetId(long id)
  {
    this.id= id;
  }

  public void GetId ()
  {
    return this.id;
  }

  public long Id  /*ES MAS SIMPLE QUE LO ANTERIOR*/
  {
    get {return this.id;}           
    set { this.id = value;}            
  }

  public string UserName       /*EL MAS USADO POR SU SIMPLESA*/
  {
    get;
    set;
  }

  public string Nºame
  { 
    get;
    set;
  }
  public string Last_Name
  { 
    get;
    set;
  }

  public string GetFullName()
  {
    return this.Name + " " + this.Last_Name 
  }

  public string url {
    get{
      return this.avatar.Path
    }
  }
}
