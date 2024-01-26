import java.util.Date;

public class PatientVital {

    public String UserId; 
    public int BloodPressureSystolic;
    public int BloodPressureDiastolic;
    public int PatientHeartRate; 
    public double PatientBodyTemp; 
	public String OverallPhysicalCondition; 
    public Date DateCreated; 

    public long timeStamp; 
    public String hash; 
	public String previousHash; 


    // Constructor for the block 
	public PatientVital(String UserId
                       ,int BloodPressureSystolic
                       ,int BloodPressureDiastolic
                       ,int PatientHeartRate
                       ,double PatientBodyTemp
                       ,String OverallPhysicalCondition
                       ,String previousHash
                       ) 
	{ 

		this.UserId = UserId; 
	    this.BloodPressureSystolic = BloodPressureSystolic; 
        this.BloodPressureDiastolic = BloodPressureDiastolic; 
        this.PatientHeartRate = PatientHeartRate; 
        this.PatientBodyTemp = PatientBodyTemp; 
        this.OverallPhysicalCondition = OverallPhysicalCondition; 
        this.DateCreated = new Date(); 
		this.timeStamp 	= new Date().getTime(); 
		this.hash = CalculateHash(); 
        this.previousHash = previousHash; 
	} 

    // Function to calculate the hash 
	public String CalculateHash() 
	{ 
		// Calling the "crypt" class to calculate the hash by using the previous hash, timestamp and the data 
		String strCalculatedHash = Crypt.sha256(previousHash+
                                             Long.toString(timeStamp)+
                                             this.UserId+
                                             this.BloodPressureSystolic+
                                             this.BloodPressureSystolic+
                                             this.PatientHeartRate+
                                             this.PatientBodyTemp+
                                             this.OverallPhysicalCondition);

		return strCalculatedHash; 
	} 
}
