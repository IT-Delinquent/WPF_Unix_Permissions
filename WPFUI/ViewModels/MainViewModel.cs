using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.ViewModels
{
    public class MainViewModel : Screen
    {
        #region Private Backing Fields

        /// <summary>
        /// Private backing field holding the value for the first octet
        /// </summary>
        private int _octetOne;

        /// <summary>
        /// Private backing field holding the value for the second octet
        /// </summary>
        private int _octetTwo;

        /// <summary>
        /// Private backing field holding the value for the third octet
        /// </summary>
        private int _octetThree;

        /// <summary>
        /// Private backing field holding the value for the fourth octet
        /// </summary>
        private int _octetFour;

        #endregion

        #region Public Fields

        /// <summary>
        /// Public get/set and notify for the first octet
        /// </summary>
        public int OctetOne
        {
            get { return _octetOne; }
            set
            {
                _octetOne = value;
                NotifyOfPropertyChange(() => OctetOne);
                NotifyOfPropertyChange(() => Example);
            }
        }

        /// <summary>
        /// Public get/set and notify for the second octet
        /// </summary>
        public int OctetTwo
        {
            get { return _octetTwo; }
            set
            {
                _octetTwo = value;
                NotifyOfPropertyChange(() => OctetTwo);
                NotifyOfPropertyChange(() => Example);
            }
        }

        /// <summary>
        /// Public get/set and notify for the third octet
        /// </summary>
        public int OctetThree
        {
            get { return _octetThree; }
            set
            {
                _octetThree = value;
                NotifyOfPropertyChange(() => OctetThree);
                NotifyOfPropertyChange(() => Example);
            }
        }

        /// <summary>
        /// Public get/set and notify for the fourth octet
        /// </summary>
        public int OctetFour
        {
            get { return _octetFour; }
            set
            {
                _octetFour = value;
                NotifyOfPropertyChange(() => OctetFour);
                NotifyOfPropertyChange(() => Example);
            }
        }

        public string Example
        {
            get
            {
                return string.Format("chmod {0}{1}{2}{3} path-to-file", OctetOne, OctetTwo, OctetThree, OctetFour);
            }
        }

        #endregion

        #region Special CheckBoxes

        /// <summary>
        /// When the Special UID checkbox is interacted with
        /// </summary>
        public bool SpecialUID
        {
            set
            {
                if (value)
                {
                    OctetOne += 4;
                }
                else
                {
                    OctetOne -= 4;
                }
            }
        }

        /// <summary>
        /// When the Special GID checkbox is interacted with
        /// </summary>
        public bool SpecialGID
        {
            set
            {
                if (value)
                {
                    OctetOne += 2;
                }
                else
                {
                    OctetOne -= 2;
                }
            }

        }


        /// <summary>
        /// When the Special Sticky Bit checkbox is interacted with
        /// </summary>
        public bool SpecialBit
        {
            set
            {
                if (value)
                {
                    OctetOne += 1;
                }
                else
                {
                    OctetOne -= 1;
                }
            }

        }

        #endregion

        #region User CheckBoxes

        /// <summary>
        /// When the User Read checkbox is interacted with
        /// </summary>
        public bool UserRead
        {
            set
            {
                if (value)
                {
                    OctetTwo += 4;
                }
                else
                {
                    OctetTwo -= 4;
                }
            }
        }

        /// <summary>
        /// When the User Write checkbox is interacted with
        /// </summary>
        public bool UserWrite
        {
            set
            {
                if (value)
                {
                    OctetTwo += 2;
                }
                else
                {
                    OctetTwo -= 2;
                }
            }
        }

        /// <summary>
        /// When the User Execute checkbox is interacted with
        /// </summary>
        public bool UserEx
        {
            set
            {
                if (value)
                {
                    OctetTwo += 1;
                }
                else
                {
                    OctetTwo -= 1;
                }
            }
        }

        #endregion

        #region Group CheckBoxes

        /// <summary>
        /// When the Group Read checkbox is interacted with
        /// </summary>
        public bool GroupRead
        {
            set
            {
                if (value)
                {
                    OctetThree += 4;
                }
                else
                {
                    OctetThree -= 4;
                }
            }
        }

        /// <summary>
        /// When the Group Write checkbox is interacted with
        /// </summary>
        public bool GroupWrite
        {
            set
            {
                if (value)
                {
                    OctetThree += 2;
                }
                else
                {
                    OctetThree -= 2;
                }
            }
        }

        /// <summary>
        /// When the Group Execute checkbox is interacted with
        /// </summary>
        public bool GroupEx
        {
            set
            {
                if (value)
                {
                    OctetThree += 1;
                }
                else
                {
                    OctetThree -= 1;
                }
            }
        }

        #endregion

        #region Other CheckBoxes    

        /// <summary>
        /// When the Other Read checkbox is interacted with
        /// </summary>
        public bool OtherRead
        {
            set
            {
                if (value)
                {
                    OctetFour += 4;
                }
                else
                {
                    OctetFour -= 4;
                }
            }
        }

        /// <summary>
        /// When the Other Write checkbox is interacted with
        /// </summary>
        public bool otherWrite
        {
            set
            {
                if (value)
                {
                    OctetFour += 2;
                }
                else
                {
                    OctetFour -= 2;
                }
            }
        }

        /// <summary>
        /// When the Other Execute checkbox is interacted with
        /// </summary>
        public bool OtherEx
        {
            set
            {
                if (value)
                {
                    OctetFour += 1;
                }
                else
                {
                    OctetFour -= 1;
                }
            }
        }

        #endregion
    }
}