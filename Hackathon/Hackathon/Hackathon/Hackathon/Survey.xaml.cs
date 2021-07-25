using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hackathon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [assembly: Xamarin.Forms.Dependency(typeof(MessageAndroid))]
    public partial class Survey : ContentPage
    {

        public Survey()
        {
            InitializeComponent();

            int qn = 0;
            List<string> qs = new List<string> { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"};

            var op1det = new TapGestureRecognizer();
            op1det.Tapped += (s, e) =>
            {
                qs.RemoveAt(qn);
                qs.Insert(qn, Op1.Text);
                Console.WriteLine(string.Join(", ", qs));
                Op3F.BackgroundColor = Color.FromHex("#fff");
                Op2F.BackgroundColor = Color.FromHex("#fff");
                Op1F.BackgroundColor = Color.FromHex("#669DB3FF");
            };

            Op1F.GestureRecognizers.Add(op1det);

            var op2det = new TapGestureRecognizer();
            op2det.Tapped += (s, e) =>
            {
                qs.RemoveAt(qn);
                qs.Insert(qn, Op2.Text);
                Console.WriteLine(string.Join(", ", qs));
                Op3F.BackgroundColor = Color.FromHex("#fff");
                Op1F.BackgroundColor = Color.FromHex("#fff");
                Op2F.BackgroundColor = Color.FromHex("#669DB3FF");
            };

            Op2F.GestureRecognizers.Add(op2det);

            var op3det = new TapGestureRecognizer();
            op3det.Tapped += (s, e) =>
            {
                qs.RemoveAt(qn);
                qs.Insert(qn, Op3.Text);
                Console.WriteLine(string.Join(", ", qs));
                Op2F.BackgroundColor = Color.FromHex("#fff");
                Op1F.BackgroundColor = Color.FromHex("#fff");
                Op3F.BackgroundColor = Color.FromHex("#669DB3FF");
            };

            Op3F.GestureRecognizers.Add(op3det);

            var next = new TapGestureRecognizer();
            next.Tapped += (s, e) =>
            {
                switch (qn)
                {
                    case 0:
                        Progress.Margin = new Thickness(30, 20, 257, 10);
                        QuestionNumber.Text = "2";
                        Question.Text = "You currently have Type 1 / 2 Diabetes?";
                        Op1.Text = "True";
                        Op2.Text = "False";
                        Op3.Text = "";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 1:
                        Progress.Margin = new Thickness(30, 20, 234, 10);
                        QuestionNumber.Text = "3";
                        Question.Text = "Describe the amount of alcohol you currently drink or have drunk for a significant portion of your life.";
                        Op1.Text = "None";
                        Op2.Text = "Light";
                        Op3.Text = "Heavy";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 2:
                        Progress.Margin = new Thickness(30, 20, 211, 10);
                        QuestionNumber.Text = "4";
                        Question.Text = "You have had any radiation treatment for any prior cancers?";
                        Op1.Text = "True";
                        Op2.Text = "False";
                        Op3.Text = "";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 3:
                        Progress.Margin = new Thickness(30, 20, 188, 10);
                        QuestionNumber.Text = "5";
                        Question.Text = "Describe your aspirin usage over the last 15 years.";
                        Op1.Text = "None";
                        Op2.Text = "Light";
                        Op3.Text = "Heavy";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 4:
                        Progress.Margin = new Thickness(30, 20, 165, 10);
                        QuestionNumber.Text = "6";
                        Question.Text = "Which describes the amount of red meat you consume on average?";
                        Op1.Text = "None";
                        Op2.Text = "Light";
                        Op3.Text = "Heavy";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 5:
                        Progress.Margin = new Thickness(30, 20, 142, 10);
                        QuestionNumber.Text = "7";
                        Question.Text = "You have had any past heart disease or problems?";
                        Op1.Text = "True";
                        Op2.Text = "False";
                        Op3.Text = "";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 6:
                        Progress.Margin = new Thickness(30, 20, 119, 10);
                        QuestionNumber.Text = "8";
                        Question.Text = "What is your standard blood pressure? Select Standard if not known.";
                        Op1.Text = "High";
                        Op2.Text = "Low";
                        Op3.Text = "Standard";
                        NextLabel.Text = "Done";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 7:
                        Progress.Margin = new Thickness(30, 20, 96, 10);
                        QuestionNumber.Text = "9";
                        Question.Text = "You have family members with heart desease?";
                        Op1.Text = "True";
                        Op2.Text = "False";
                        Op3.Text = "";
                        NextLabel.Text = "Done";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 8:
                        Progress.Margin = new Thickness(30, 20, 73, 10);
                        QuestionNumber.Text = "10";
                        Question.Text = "Do you have any family members with high blood pressure?";
                        Op1.Text = "True";
                        Op2.Text = "False";
                        Op3.Text = "";
                        NextLabel.Text = "Done";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 9:
                        Progress.Margin = new Thickness(30, 20, 50, 10);
                        QuestionNumber.Text = "11";
                        Question.Text = "Do you have any family members with cancer?";
                        Op1.Text = "None";
                        Op2.Text = "Single";
                        Op3.Text = "Multiple";
                        NextLabel.Text = "Done";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 10:
                        Progress.Margin = new Thickness(30, 20, 27, 10);
                        QuestionNumber.Text = "12";
                        Question.Text = "Do you have any family members with  Alzeimer's?";
                        Op1.Text = "None";
                        Op2.Text = "Single";
                        Op3.Text = "Multiple";
                        NextLabel.Text = "Done";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 11:
                        Progress.Margin = new Thickness(30, 20, 28, 10);
                        QuestionNumber.Text = "13";
                        Question.Text = "Which is your biological sex?";
                        Op1.Text = "Male";
                        Op2.Text = "Female";
                        Op3.Text = "Intersex/Other";
                        NextLabel.Text = "Done";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 12:
                        Progress.Margin = new Thickness(30, 20, 28, 10);
                        QuestionNumber.Text = "14";
                        Question.Text = "Which best descries your ethnicity/decent";
                        Op1.Text = "African";
                        Op2.Text = "Asian";
                        Op3.Text = "Caucasian";
                        NextLabel.Text = "Done";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 13:
                        Progress.Margin = new Thickness(30, 20, 28, 10);
                        QuestionNumber.Text = "15";
                        Question.Text = "Which best descries your current weight in relation to your age, height, etc.";
                        Op1.Text = "Underweight";
                        Op2.Text = "Standard";
                        Op3.Text = "Overweight";
                        NextLabel.Text = "Done";
                        Op1F.BackgroundColor = Color.FromHex("#fff");
                        Op2F.BackgroundColor = Color.FromHex("#fff");
                        Op3F.BackgroundColor = Color.FromHex("#fff");
                        break;

                    case 14:
                        int age = 45;
                        bool smoking = bool.Parse(qs[0]);
                        bool diabetes = bool.Parse(qs[1]);
                        string alcohol = qs[2];
                        bool pastCancerTreatment = bool.Parse(qs[3]);
                        string aspirinUsage = qs[4];
                        string redMeat = qs[5];
                        bool heartProblems = bool.Parse(qs[6]);
                        string bloodPressure = qs[7];
                        bool familyHeartDiseaseHistory = bool.Parse(qs[8]);
                        bool familyHighBpHistory = bool.Parse(qs[9]);
                        string familyCancerHistory = qs[10];
                        string familyAlzheimersHistory = qs[11];
                        string gender = qs[12];
                        string ethnicity = qs[13];
                        string bmi = "";
                        if (qs[14].Equals("Overweight"))
                        {
                            bmi = "High";
                        }
                        else
                        {
                            bmi = "Other";
                        }

                        HeartAttackEvaluation heartAttackEval = new HeartAttackEvaluation();
                        string heartAttackRisk = heartAttackEval.healthEval(age, gender, ethnicity, smoking, bmi, diabetes, alcohol);
                        Console.WriteLine("Heart Attack Risk: " + heartAttackRisk);

                        StrokeEvaluation strokeEval = new StrokeEvaluation();
                        String strokeRisk = strokeEval.healthEval(gender, age, diabetes, ethnicity, smoking, bloodPressure, heartProblems);
                        Console.WriteLine("Stroke Risk: " + strokeRisk);

                        AlzheimersDiseaseEvaluation alzheimersEval = new AlzheimersDiseaseEvaluation();
                        String alzheimersRisk = alzheimersEval.healthEval(age, familyAlzheimersHistory, bloodPressure, diabetes, heartProblems);
                        Console.WriteLine("Alzheimers Risk: " + alzheimersRisk);

                        HypertensionEvaluation hypertensionEval = new HypertensionEvaluation();
                        String hypertensionRisk = hypertensionEval.healthEval(bloodPressure, diabetes, bmi, alcohol, smoking, familyHighBpHistory, ethnicity, age);
                        Console.WriteLine("Hypertension Risk: " + hypertensionRisk);

                        ColonCancerEvaluation colonCancerEval = new ColonCancerEvaluation();
                        String colonCancerRisk = colonCancerEval.healthEval(age, ethnicity, familyCancerHistory, diabetes, bmi, smoking, alcohol, pastCancerTreatment);
                        Console.WriteLine("Colon Cancer Risk: " + colonCancerRisk);

                        HeartDiseaseEvaluation heartDiseaseEval = new HeartDiseaseEvaluation();
                        String heartDiseaseRisk = heartDiseaseEval.healthEval(bloodPressure, diabetes, bmi, alcohol, smoking, gender, familyHeartDiseaseHistory, age);
                        Console.WriteLine("Heart Disease Risk: " + heartDiseaseRisk);

                        Op1.Text = "Colon Cancer: " + colonCancerRisk;
                        Op2.Text = "Hypertension: " + hypertensionRisk;
                        Op3.Text = "Heart Attack: " + heartAttackRisk;
                        Question.Text = "Results";

                        break;

                    default:
                        break;
                }

                qn += 1;
            };
            Next.GestureRecognizers.Add(next);
            
        }
    }

    class HeartAttackEvaluation
    {

        public double risk = 0; //Risk value which will determine the risk level for user
        public string evaluation = ""; //Final risk evaluation

        public string healthEval(int age, string gender, string ethnicity, bool smoking, string bmi, bool diabetes, string alcohol)
        {

            risk = 0; //Risk value which will increase with risk factors

            if (age >= 55)
            { //Old age is a risk factor of heart attacks
                risk = risk + 0.75;

            }
            else
            {
                if (gender.Equals("Male"))
                {

                    if (age >= 45)
                    { //Men face the risk factor of heart attacks at a younger age
                        risk = risk + 0.75;

                    }
                }
            }

            if (gender.Equals("Male"))
            {
                risk = risk + 0.25; //Males have a higher chance for heart attacks
            }

            if (!ethnicity.Equals("Caucasian"))
            {
                risk = risk + 0.25; //Minorities have a higher chance for heart attacks
            }

            if (smoking)
            {
                risk = risk + 0.5; //Smoking is a risk factor of heart attacks
            }

            if (alcohol.Equals("Heavy"))
            {
                risk = risk + 0.75; //Alcoholism is a significant risk factor of heart attacks
            }

            if (diabetes)
            {
                risk = risk + 0.5; //Diabetes is a risk factor of heart attacks
            }

            if (bmi.Equals("High"))
            {
                risk = risk + 0.75; //Obesity is a significant risk factor of heart attacks
            }

            if (risk >= 2)
            { //A high risk vlaue = high risk evaluation
                evaluation = "High Risk";
                return evaluation;
            }
            else if (risk >= 1)
            { //A medium risk value = medium risk evaluation 
                evaluation = "Medium Risk";
                return evaluation;
            }
            else
            { //A low risk value = low risk evaluation
                evaluation = "Low Risk";
                return evaluation;
            }
        }
    }

    class AlzheimersDiseaseEvaluation
    {
        public double risk = 0; //Risk value which will determine the risk level for user
        public string evaluation = ""; //Final risk evaluation

        public string healthEval(int age, string familyAlzheimersHistory, string bloodPressure, bool diabetes, bool heartProblems)
        {
            if (age >= 85)
            {
                risk++;
            }
            else if (age >= 75)
            {
                risk = risk + 0.75;
            }
            else if (age >= 65)
            {
                risk += 0.5;
            }

            if (familyAlzheimersHistory.Equals("Single"))
            {
                risk += 0.5;
            }

            if (familyAlzheimersHistory.Equals("Multiple"))
            {
                risk += 0.75;
            }

            if (bloodPressure.Equals("High"))
            {
                risk++;
            }

            if (diabetes)
            {
                risk++;

            }

            if (heartProblems)
            {
                risk++;
            }

            if (risk >= 2)
            {
                return "High Risk";
            }

            if (risk >= 1.5)
            {
                return "Medium Risk";
            }

            return "Low Risk";

        }
    }

    class HypertensionEvaluation
    {
        public double risk = 0; //Risk value which will determine the risk level for user
        public string evaluation = ""; //Final risk evaluation

        public string healthEval(string bloodPressure, bool diabetes, string bmi, string alcohol, bool smoking, bool familyHighBpHistory, string ethnicity, int age)
        {
            if (bloodPressure.Equals("High"))
            {
                risk += 0.75;
            }

            if (diabetes)
            {
                risk += 0.5;
            }

            if (bmi.Equals("High"))
            {
                risk += 0.5;
            }

            if (alcohol.Equals("Heavy"))
            {
                risk += 0.5;
            }

            if (smoking)
            {
                risk += 0.5;
            }

            if (familyHighBpHistory)
            {
                risk += 0.5;
            }

            if (ethnicity.Equals("African"))
            {
                risk += 0.5;
            }

            if (age >= 60)
            {
                risk += 0.75;
            }
            else
            {
                if (age >= 35)
                {
                    risk += 0.5;
                }
            }

            if (risk > 2)
            {
                return "High Risk";
            }
            else if (risk >= 1.5)
            {
                return "Medium Risk";
            }

            return "Low Risk";
        }
    }

    class ColonCancerEvaluation
    {
        public double risk = 0; //Risk value which will determine the risk level for userb
        public string evaluation = ""; //Final risk evaluation

        public string healthEval(int age, string ethnicity, string familyCancerHistory, bool diabetes, string bmi, bool smoking, string alcohol, bool pastCancerTreatment)
        {
            if (age >= 50)
            { //Old age is a risk factor of Colon Cancer
                risk += 0.5;
            }

            if (ethnicity.Equals("African"))
            { //Africans are at higher risk for Colon Cancer
                risk += 0.5;
            }

            if (familyCancerHistory.Equals("Single"))
            { //Having a relative with the disease increases the risk of Colon Cancer
                risk += 0.5;
            }

            if (familyCancerHistory.Equals("Multiple"))
            { //Having mutiple relatives with the disease increases the risk of Colon Cancer even more
                risk += 0.75;
            }

            if (diabetes)
            { //Diabetes increases the risk of Colon Cancer
                risk += 0.5;
            }

            if (bmi.Equals("High"))
            { //Obesity increases the risk for Colon Cancer
                risk += 0.5;
            }

            if (smoking)
            { //Smoking may increase risk
                risk += 0.25;
            }

            if (alcohol.Equals("Heavy"))
            { //Heavy alcohol usage increases risk
                risk += 0.5;
            }

            if (pastCancerTreatment)
            { //Past radiation treatment for prior cancers can increase risk
                risk += 0.5;
            }

            if (risk > 2)
            {
                evaluation = "High Risk";
                return evaluation;
            }
            else if (risk > 1.2)
            {
                evaluation = "Medium Risk";
                return evaluation;
            }

            evaluation = "Low Risk";

            return evaluation;
        }
    }

    class StrokeEvaluation
    {
        public double risk = 0; //Risk value which will determine the risk level for user
        public string evaluation = ""; //Final risk evaluation

        public string healthEval(string gender, int age, bool diabetes, string ethnicity, bool smoking, string bloodPressure, bool heartProblems)
        {
            if (gender.Equals("Male"))
            { //Higher occurence in Men; More dangerous for women
                risk += 0.25;
            }

            if (age >= 75)
            { //Significant risk increase after 55
                risk += 1;
            }
            else if (age >= 65)
            {
                //Significant risk increase after 55
                risk += 0.75;

            }
            else
            {
                if (age >= 55)
                { //Significant risk increase after 55
                    risk += 0.5;
                }
            }

            if (diabetes)
            { //Diabetes increases risk factor
                risk += 0.5;
            }

            if (ethnicity.Equals("African"))
            {
                risk += 0.5;
            }

            if (smoking)
            { //Smoking can double your risk factor
                risk += 0.75;
            }

            if (heartProblems)
            { //2nd Most important Factor for Risk
                risk += 0.75;

            }

            if (bloodPressure.Equals("High"))
            { //High blood pressure is a major danger that can lead to strokes
                risk += 0.5;
            }

            if (bloodPressure.Equals("Low"))
            { //Low blood pressure can be dangerous and also lead to stroke 
                risk += 0.25;

            }

            if (risk >= 2.5)
            {
                return "High Risk";
            }
            else if (risk >= 1.5)
            {
                return "Medium Risk";
            }

            return "Low Risk";
        }
    }

    class HeartDiseaseEvaluation
    {
        public double risk = 0; //Risk value which will determine the risk level for userb
        public string evaluation = ""; //Final risk evaluation

        public string healthEval(string bloodPressure, bool diabetes, string bmi, string alcohol, bool smoking, string gender, bool familyHeartDiseaseHistory, int age)
        {
            if (bloodPressure.Equals("High"))
            { //Major RIsk Factor; Symptomless and must be detected w/ a test
                risk += 0.75;
            }

            if (diabetes)
            { //Risk Factor 
                risk += 0.5;
            }

            if (bmi.Equals("High"))
            { //Obesity can lead to other factors that are Risk factors
                risk += 0.5;
            }

            if (alcohol.Equals("Heavy"))
            { //High alcohol raises blood pressure and thus is a risk factor
                risk += 0.5;
            }

            if (smoking)
            { //Smoking is a risk factor
                risk += 0.5;
            }

            if (gender.Equals("Male"))
            { //Males are more likely to get heart disease
                risk += 0.25;
            }

            if (familyHeartDiseaseHistory)
            { //Family history of disease can increase risk of disease
                risk += 0.25;
            }

            if (age >= 65)
            { //65 and older are more at risk of heart disease
                risk += 0.75;
            }

            if (risk > 2)
            {
                return "High Risk";
            }
            else if (risk >= 1.5)
            {
                return "Medium Risk";
            }

            return "Low Risk";
        }
    }
}

