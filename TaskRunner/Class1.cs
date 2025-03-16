using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskRunner
{
    public class BOX
    {
        public double height, length, breadth;


        public static BOX operator *(BOX obj1, float num)
        {
            obj1.height *= num;
            return obj1;
        }

        public static BOX operator ++(BOX obj1)
        {
            obj1.height += 1;
            return obj1;
        }

        public static BOX operator --(BOX obj1)
        {
            obj1.height += 1;
            return obj1;
        }

        public static bool operator ==(BOX obj1, BOX obj2)
        {
            return (obj1.length == obj2.length
                        && obj1.breadth == obj2.breadth
                        && obj1.height == obj2.height);
        }

        public static bool operator !=(BOX obj1, BOX obj2)
        {
            return !(obj1.length == obj2.length
                        && obj1.breadth == obj2.breadth
                        && obj1.height == obj2.height);
        }

        public override bool Equals(object obj)
        {
            BOX? box = obj as BOX;
            return (length == box?.length
                        && breadth == box?.breadth
                        && height == box?.height);
        }


        public void check() 
        {
            BOX box = new BOX();
            box.height = 10;
            bool isEqual = box == this;
        }
    }

}

interface ILeftHanded
{
    string Hand { get; }
}
interface IRightHanded
{
    string Hand { get; }
}
interface IGinger
{
    string Hair { get; }
}
interface IBlond
{
    string Hair { get; }
}

interface IleftGinger : ILeftHanded, IGinger
{
}

interface IRightGinger : IRightHanded, IGinger
{
}

interface IleftBlond : ILeftHanded, IBlond
{
}

interface IRightBlond : IRightHanded, IBlond
{
}

interface IPerson : ILeftHanded, IGinger, IRightHanded, IBlond { }

interface IMultiCastPerson : 
    IleftGinger, IRightGinger, 
    IleftBlond, IRightBlond
{ 
}

class Person : IMultiCastPerson
{

    string ILeftHanded.Hand => "left hand";

    string IRightHanded.Hand => "Right Hand";

    string IGinger.Hair => "ginge";

    string IBlond.Hair => "dumb";

}

class Bouncer
{
    public bool AllowEntrance(IRightBlond person)
    {
        return true;
    }
    public bool AllowEntrance(IleftBlond person)
    {
        return true;
    }
    public bool AllowEntrance(IleftGinger person)
    {
        return false;
    }
    public bool AllowEntrance(IRightGinger person)
    {
        return true;
    }

}







interface ICoreSecretAdapter
{
    string GetSecret(string key);
}

interface IResourceSecretAdapter
{
    string GetSecret(string key);
}

interface ISecretAdapter : ICoreSecretAdapter, IResourceSecretAdapter
{
    
}

public enum SecretClientType
{
    Core,
    Resource
}





public class KeyVaultAdapter
{
    private IDictionary<SecretClientType, KeyVaultClient> _clients;

    public KeyVaultAdapter(IDictionary<SecretClientType,KeyVaultClient> clients)
    {
        _clients = clients;
    }

    string GetSecret(string key, SecretClientType type = SecretClientType.Resource)
    {
        var client = _clients[type];
        return client.GetSecretFromAzure(key);
    }
}

public class KeyVaultClient
{
    public string GetSecretFromAzure(string key)
    {
        return "";
    }
}


public class Rootobject
{
    public string redirectUri { get; set; }
    public string partnerFinancialApplicationId { get; set; }
    public Data data { get; set; }
}

public class Data
{
    public string redirectUri { get; set; }
    public Financialapplication financialApplication { get; set; }
}

public class Financialapplication
{
    public string productLine { get; set; }
    public Applicationproperties applicationProperties { get; set; }
    public Orderinformation orderInformation { get; set; }
    public Applicantinformation[] applicantInformation { get; set; }
    public Vehicleinformation vehicleInformation { get; set; }
    public Financialinformation financialInformation { get; set; }
}

public class Applicationproperties
{
    public string applicationType { get; set; }
    public string financeApplicationCode { get; set; }
}

public class Orderinformation
{
    public string referenceNumber { get; set; }
    public string currencyCode { get; set; }
    public string countryCode { get; set; }
    public string locale { get; set; }
    public object scheduledDeliveryDateInUTC { get; set; }
}

public class Vehicleinformation
{
    public string saleClass { get; set; }
    public string model { get; set; }
    public string trimCodeDescription { get; set; }
    public string modelImageUrl { get; set; }
    public int year { get; set; }
    public object vin { get; set; }
    public object licensePlate { get; set; }
    public int odometer { get; set; }
    public string odometerUnit { get; set; }
    public object firstRegistrationDateInUTC { get; set; }
}

public class Financialinformation
{
    public float totalFees { get; set; }
    public string financeType { get; set; }
    public string productCategory { get; set; }
    public string financePartnerProfileCode { get; set; }
    public float requestedFinanceAmount { get; set; }
    public float adjustedPurchasePrice { get; set; }
    public float baseVehiclePrice { get; set; }
    public int term { get; set; }
    public float interestRate { get; set; }
    public int distanceAllowed { get; set; }
    public string distanceAllowedUnit { get; set; }
    public float overageCharge { get; set; }
    public Incentives incentives { get; set; }
}

public class Incentives
{
    public int ElectricalVehicleIncentive { get; set; }
}

public class Applicantinformation
{
    public string businessName { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string phoneNumber { get; set; }
    public string phoneNumberCountryCode { get; set; }
    public Address[] addresses { get; set; }
}

public class Address
{
    public string addressLine1 { get; set; }
    public string city { get; set; }
    public string stateOrProvince { get; set; }
    public string countryCode { get; set; }
    public string postalCode { get; set; }
    public string addressType { get; set; }
    public string residenceType { get; set; }
}
