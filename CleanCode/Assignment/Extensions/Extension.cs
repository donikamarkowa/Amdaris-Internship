using Assignment.Entities;
using Assignment.Exceptions;
using Assignment.Repositories;

namespace Assignment.Extensions
{
    public static class Extension
    {
        /// <summary>
        /// Register a speaker
        /// </summary>
        /// <returns>speakerID</returns>
        public static int? Register(this Speaker speaker, IRepository<Speaker> repository, Data data, WebBrowser browser)
        {
            try
            {
                ValidateSpeaker(speaker);
                IsGood(data, speaker, browser);
                SessionApproval(speaker, data);
                SetRegistrationFee(speaker);
                return repository.SaveSpeaker(speaker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SpeakerDoesntMeetRequirementsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NoSessionsApprovedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;

        }

        private static void ValidateSpeaker(Speaker speaker)
        {
            if (string.IsNullOrWhiteSpace(speaker.FirstName))
            {
                throw new ArgumentException("First Name is required");
            }

            if (string.IsNullOrWhiteSpace(speaker.LastName))
            {
                throw new ArgumentException("Last name is required.");
            }

            if (string.IsNullOrWhiteSpace(speaker.Email))
            {
                throw new ArgumentException("Email is required.");
            }
        }

        private static void IsGood(Data data, Speaker speaker, WebBrowser browser)
        {
            var good = speaker.Experience > 10 || speaker.HasBlog || speaker.Certifications.Count() > 3 || data.Employees.Contains(speaker.Employer);
            if (!good)
            {
                //need to get just the domain from the email
                string emailDomain = speaker.Email.Split('@').Last();

                if (!data.Domains.Contains(emailDomain) && !(speaker.Browser.Name == browser.Name && speaker.Browser.MajorVersion < 9))
                {
                    good = true;
                }
            }
            else
            {
                throw new SpeakerDoesntMeetRequirementsException("Speaker doesn't meet our abitrary and capricious standards.");
            }
        }

        private static void SessionApproval(Speaker speaker, Data data)
        {
            if (speaker.Sessions.Count() != 0)
            {
                foreach (var session in speaker.Sessions)
                {
                    //foreach (var tech in nt)
                    //{
                    //    if (session.Title.Contains(tech))
                    //    {
                    //        session.Approved = true;
                    //        break;
                    //    }
                    //}

                    bool appr = false;

                    foreach (var tech in data.Ot)
                    {
                        if (session.Title.Contains(tech) || session.Description.Contains(tech))
                        {
                            session.Approved = false;
                            break;
                        }
                        else
                        {
                            session.Approved = true;
                            appr = true;
                        }
                    }
                }
            }
            else
            {
                throw new ArgumentException("Can't register speaker with no sessions to present.");
            }
        }

        private static void SetRegistrationFee(Speaker speaker)
        {
            if (speaker.Experience <= 1)
            {
                speaker.RegistrationFee = 500;
            }
            else if (speaker.Experience >= 2 && speaker.Experience <= 3)
            {
                speaker.RegistrationFee = 250;
            }
            else if (speaker.Experience >= 4 && speaker.Experience <= 5)
            {
                speaker.RegistrationFee = 100;
            }
            else if (speaker.Experience >= 6 && speaker.Experience <= 9)
            {
                speaker.RegistrationFee = 50;
            }
            else
            {
                speaker.RegistrationFee = 0;
            }
        }
    }
}
