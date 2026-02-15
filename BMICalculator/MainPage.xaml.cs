namespace BMICalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string gender = "";

        private void TapMale_Tapped(object sender, TappedEventArgs e)
        {
            gender = "Male";
            FrameMale.BackgroundColor = Color.FromArgb("#ededed");
            FrameFemale.BackgroundColor = Colors.White;

            btnCalculate.IsEnabled = true;
            btnCalculate.BackgroundColor = Colors.DarkBlue;
            btnCalculate.TextColor = Colors.White;
        }

        private void TapFemale_Tapped(object sender, TappedEventArgs e)
        {
            gender = "Female";
            FrameFemale.BackgroundColor = Color.FromArgb("#ededed");
            FrameMale.BackgroundColor = Colors.White;

            btnCalculate.IsEnabled = true;
            btnCalculate.BackgroundColor = Colors.DarkBlue;
            btnCalculate.TextColor = Colors.White;
        }

        private async void btnCalculate_Clicked(object sender, EventArgs e)
        {
            double height = SliderHeight.Value;
            double weight = SliderWeight.Value;
            double bmi = (weight * 703) / (height * height);
            string category = "";
            string recommendation = "";

            if (gender == "Male") {
                if (bmi < 18.5)
                {
                    category = "Underweight";
                    recommendation = "Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, whole grains). Incorporate strength training to build muscle mass. Consult a nutritionist if needed.";
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    category = "Normal weight";
                    recommendation = "Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week. Keep regular check-ups to monitor overall health.";
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    category = "Overweight";
                    recommendation = "Reduce processed foods and focus on portion control. Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training. Drink plenty of water and track your progress.";
                }
                else
                {
                    category = "Obese";
                    recommendation = "Consult a doctor for personalized guidance. Start with low-impact exercises (e.g., walking, cycling). Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary drinks and maintain a consistent sleep schedule.";
                }
            } else if (gender == "Female")
            {
                if (bmi < 18)
                {
                    category = "Underweight";
                    recommendation = "Increase calorie intake with nutrient-rich foods (e.g., nuts, lean protein, whole grains). Incorporate strength training to build muscle mass. Consult a nutritionist if needed.";
                }
                else if (bmi >= 18 && bmi < 24)
                {
                    category = "Normal weight";
                    recommendation = "Maintain a balanced diet with proteins, healthy fats, and fiber. Stay physically active with at least 150 minutes of exercise per week. Keep regular check-ups to monitor overall health.";
                }
                else if (bmi >= 24 && bmi < 29)
                {
                    category = "Overweight";
                    recommendation = "Reduce processed foods and focus on portion control. Engage in regular aerobic exercises (e.g., jogging, swimming) and strength training. Drink plenty of water and track your progress.";
                }
                else
                {
                    category = "Obese";
                    recommendation = "Consult a doctor for personalized guidance. Start with low-impact exercises (e.g., walking, cycling). Follow a structured weight-loss meal plan and consider behavioral therapy for lifestyle changes. Avoid sugary drinks and maintain a consistent sleep schedule.";
                }
            }

            await DisplayAlert(
                "BMI Result",
                $"Gender: {gender}\n" +
                $"BMI: {bmi:F1}\n" +
                $"Category: {category}\n\n" +
                $"Recommendation:\n{recommendation}",
                "OK");
        }
    }
}
