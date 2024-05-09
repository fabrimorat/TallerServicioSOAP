using System;
using System.Runtime.Serialization;
using System.ServiceModel;

// Definición de la interfaz IService que actúa como un contrato para el servicio SOAP.
[ServiceContract]
public interface IService
{
    // Operación que devuelve un string basado en un valor entero proporcionado.
    [OperationContract]
    string GetData(int value);

    // Operación que maneja un tipo complejo, modifica y devuelve el mismo tipo.
    [OperationContract]
    CompositeType GetDataUsingDataContract(CompositeType composite);
}

// Definición del tipo compuesto CompositeType que se utiliza en una de las operaciones de servicio.
[DataContract]
public class CompositeType
{
    private bool boolValue = true;
    private string stringValue = "Hello ";

    // Indica si el valor booleano es verdadero o falso.
    [DataMember]
    public bool BoolValue
    {
        get { return boolValue; }
        set { boolValue = value; }
    }

    // Cadena de texto asociada con la instancia de este tipo.
    [DataMember]
    public string StringValue
    {
        get { return stringValue; }
        set { stringValue = value; }
    }
}
