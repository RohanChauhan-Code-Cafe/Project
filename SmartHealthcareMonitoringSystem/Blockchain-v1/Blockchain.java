// Java implementation to store blocks into "ArrayList"
import java.util.ArrayList;

public class Blockchain {

    public static ArrayList<PatientVital> ObjPatientVitalBlockchain = new ArrayList<PatientVital>();

    public static void main(String[] args)
	{
		
        ObjPatientVitalBlockchain.add(new PatientVital("user1", 120,80,77,95.50,"Good","0"));
        ObjPatientVitalBlockchain.add(new PatientVital("user2", 125,85,80,96.50,"Average",ObjPatientVitalBlockchain.get(ObjPatientVitalBlockchain.size() - 1).hash));
        ObjPatientVitalBlockchain.add(new PatientVital("user3", 130,90,83,97.50,"Average",ObjPatientVitalBlockchain.get(ObjPatientVitalBlockchain.size() - 1).hash));
        ObjPatientVitalBlockchain.add(new PatientVital("user4", 135,95,86,98.50,"Bad",ObjPatientVitalBlockchain.get(ObjPatientVitalBlockchain.size() - 1).hash));
        ObjPatientVitalBlockchain.add(new PatientVital("user5", 140,100,89,99.50,"Bad",ObjPatientVitalBlockchain.get(ObjPatientVitalBlockchain.size() - 1).hash));

        for (PatientVital dt : ObjPatientVitalBlockchain) {
            System.out.println("UserId: "+dt.UserId);
            System.out.println("BloodPressureSystolic: "+dt.BloodPressureSystolic);
            System.out.println("BloodPressureDiastolic: "+dt.BloodPressureDiastolic);
            System.out.println("PatientHeartRate: "+dt.PatientHeartRate);
            System.out.println("PatientBodyTemp: "+dt.PatientBodyTemp);
            System.out.println("OverallPhysicalCondition: "+dt.OverallPhysicalCondition);
            System.out.println("DateCreated: "+dt.DateCreated);
            System.out.println("TimeStamp: "+dt.timeStamp);
            System.out.println("Hash: "+dt.hash);
            System.out.println("PreviousHash: "+dt.previousHash);
      
            System.out.println("");
        }
	}
}
