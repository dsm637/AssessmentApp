using System.Text.Json;

namespace TestProject1
{
    public class JsonSerializationTests
    {
        private const string Cities = @"[
  {
    ""name"": ""Waltham"",
    ""latitude"": 42.3756401,
    ""longitude"": -71.2358004,
    ""country"": ""US"",
    ""state"": ""Massachusetts""
  },
  {
    ""name"": ""Waltham"",
    ""latitude"": 44.12589065,
    ""longitude"": -73.23344498851795,
    ""country"": ""US"",
    ""state"": ""Vermont""
  },
  {
    ""name"": ""Waltham"",
    ""latitude"": 44.7092404,
    ""longitude"": -68.3383535,
    ""country"": ""US"",
    ""state"": ""Maine""
  },
  {
    ""name"": ""Waltham"",
    ""latitude"": 43.8216451,
    ""longitude"": -92.8771918,
    ""country"": ""US"",
    ""state"": ""Minnesota""
  },
  {
    ""name"": ""Waltham"",
    ""latitude"": 41.4331802,
    ""longitude"": -89.0103533,
    ""country"": ""US"",
    ""state"": ""Illinois""
  }
]";

        private const string Parks = @"
{
  ""total"": ""18"",
  ""limit"": ""50"",
  ""start"": ""0"",
  ""data"": [
    {
      ""id"": ""E4C7784E-66A0-4D44-87D0-3E072F5FEF43"",
      ""url"": ""https://www.nps.gov/adam/index.htm"",
      ""fullName"": ""Adams National Historical Park"",
      ""parkCode"": ""adam"",
      ""description"": ""From the sweet little farm at the foot of Penn�s Hill to the gentleman�s country estate at Peace field, Adams National Historical Park is the story of �heroes, statesmen, philosophers�and learned women� whose ideas and actions helped to transform thirteen disparate colonies into one united nation."",
      ""latitude"": ""42.2553961"",
      ""longitude"": ""-71.01160356"",
      ""latLong"": ""lat:42.2553961, long:-71.01160356"",
      ""activities"": [
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""B204DE60-5A24-43DD-8902-C81625A09A74"",
          ""name"": ""Living History""
        },
        {
          ""id"": ""28880A5B-3D29-41AC-BD8B-24743E7A070F"",
          ""name"": ""First Person Interpretation""
        },
        {
          ""id"": ""0C0D142F-06B5-4BE1-8B44-491B90F93DEB"",
          ""name"": ""Park Film""
        },
        {
          ""id"": ""24380E3F-AD9D-4E38-BF13-C8EEB21893E7"",
          ""name"": ""Shopping""
        },
        {
          ""id"": ""467DC8B8-0B7D-436D-A026-80A22358F615"",
          ""name"": ""Bookstore and Park Store""
        }
      ],
      ""topics"": [
        {
          ""id"": ""F3883A66-A7CB-461B-868E-1B5932224B25"",
          ""name"": ""American Revolution""
        },
        {
          ""id"": ""7DA81DAB-5045-4953-9C20-36590AD9FA95"",
          ""name"": ""Women's History""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""617-773-1177"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""ADAM_Visitor_Center@nps.gov""
          }
        ]
      },
      ""entranceFees"": [
        {
          ""cost"": ""1.00"",
          ""description"": ""The park offers tours of the historic homes. A reservation is required to attend a guided tour. It is strongly recommended to make reservations in advance on Adams National Historical Park's Recreation.gov page. A limited number of reservations will be available day-of for free on a first-come, first-served basis at the Visitor Center."",
          ""title"": ""Timed Entry Reservation - Location""
        },
        {
          ""cost"": ""15.00"",
          ""description"": ""Entrance into the historic homes at Adams National Historical Park requires an entrance pass. Entrance passes cost $15 per person. Children under the age of 16 are free. If you have an America the Beautiful Interagency Pass, you do not need to pay the entrance fee. Tours can be reserved online in advance at recreation.gov or in-person on the day of your visit at the park�s visitor center. Tour reservations are required in addition to entrance passes."",
          ""title"": ""Entrance - Per Person""
        }
      ],
      ""entrancePasses"": [
        {
          ""cost"": ""45.00"",
          ""description"": ""Adams National Historical Park has a digital annual pass available for purchase on Recreation.gov.  This pass is good for 12 months following the purchase of the pass.  Tickets are still required to enter the park, but the digital annual pass will ensure the passholder free entry into the park.  The pass costs $45."",
          ""title"": ""Annual Entrance - Park""
        }
      ],
      ""fees"": [],
      ""directionsInfo"": ""Traveling on U.S. Interstate 93, take exit 7 - Route 3 South to Braintree and Cape Cod. Take the first exit off Route 3 south - exit 42 - and follow signs toward Quincy Center. Continue straight on Burgin Parkway through six traffic lights. At the seventh traffic light, turn right onto Dimmock Street. Follow Dimmock Street one block and turn right onto Hancock Street. The National Park Service Visitor Center, located at 1250 Hancock Street on your left. Validated parking is in the garage to the rear."",
      ""directionsUrl"": ""http://www.nps.gov/adam/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-05-27"",
              ""name"": ""Memorial Day"",
              ""endDate"": ""2024-05-27""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-09-02"",
              ""name"": ""Labor Day"",
              ""endDate"": ""2024-09-02""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-10-07"",
              ""name"": ""Columbus Day"",
              ""endDate"": ""2024-10-07""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-11"",
              ""name"": ""Veterans Day"",
              ""endDate"": ""2024-11-11""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving Day"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Years Day"",
              ""endDate"": ""2025-01-01""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-20"",
              ""name"": ""Birthday of Martin Luther King, Jr."",
              ""endDate"": ""2025-01-20""
            }
          ],
          ""description"": ""The park, including the Visitor Center and the historic homes, is open Wednesday through Sunday 9am to 5pm now through October 31. The park grounds remain open dawn until dusk."",
          ""standardHours"": {
            ""wednesday"": ""9:00AM - 5:00PM"",
            ""monday"": ""Closed"",
            ""thursday"": ""9:00AM - 5:00PM"",
            ""sunday"": ""9:00AM - 5:00PM"",
            ""tuesday"": ""Closed"",
            ""friday"": ""9:00AM - 5:00PM"",
            ""saturday"": ""9:00AM - 5:00PM""
          },
          ""name"": ""All Park""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""02169"",
          ""city"": ""Quincy"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""135 Adams Street"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": """"
        },
        {
          ""postalCode"": ""02169"",
          ""city"": ""Quincy"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""135 Adams Street"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": """"
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""The John and John Quincy Adams Birthplaces"",
          ""altText"": ""The Birthplaces of Presidents John Adams (right) and John Quincy Adams (left)"",
          ""caption"": ""The Birthplaces of John and John Quincy Adams sit right next  to each other on Franklin Street."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7C7416-1DD8-B71B-0B1B30D0827F7C74.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""The Birthplace of John Adams"",
          ""altText"": ""The Birthplace of John Adams"",
          ""caption"": ""The house where President John Adams was born in 1735."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7C7565-1DD8-B71B-0BEC729A3E865792.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""The Birthplace of John Quincy Adams"",
          ""altText"": ""The Birthplace of John Quincy Adams"",
          ""caption"": ""The house where President John Quincy Adams was born in 1767."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7C76BE-1DD8-B71B-0B6DFACFB45AC5A4.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Old House at Peace field"",
          ""altText"": ""A view of Old House at Peace field"",
          ""caption"": ""Old House at Peace field, where four generations of the Adams family lived from 1788 to 1927."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7C780E-1DD8-B71B-0B18B8DB9F39704F.jpg""
        },
        {
          ""credit"": ""NPS Photo / Betty Brown"",
          ""title"": ""The Paneled Room"",
          ""altText"": ""The Paneled Room located inside Old House at Peace field."",
          ""caption"": ""The Paneled Room greets everyone who enters Old House at Peace field."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7C7945-1DD8-B71B-0BE14B48DD78B777.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""The Stone Library"",
          ""altText"": ""The Stone Library located outside Old House at Peace field."",
          ""caption"": ""The Stone Library houses up to 14,000 books belonging to the Adams family."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7C7A77-1DD8-B71B-0BDA92321AD899C5.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Inside the Stone Library"",
          ""altText"": ""Inside the Stone Library"",
          ""caption"": ""A view into the Stone Library"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7C7BE3-1DD8-B71B-0B864F7398605B7E.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""The Gardens Located at Old House at Peace field"",
          ""altText"": ""The gardens located at Old House at Peace field."",
          ""caption"": ""The gardens located by Old House at Peace field bloom in every color you can imagine."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7C7D4E-1DD8-B71B-0B48B5CDE41703D7.jpg""
        }
      ],
      ""weatherInfo"": ""Be prepared for hot, humid weather. The historic homes are not air conditioned. While the visitor center remains open all year, the historic homes are generally closed from approximately November 1 through April 30th."",
      ""name"": ""Adams"",
      ""designation"": ""National Historical Park"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""FAEF5684-83A4-4CF2-A701-60CF8D4014BD"",
      ""url"": ""https://www.nps.gov/appa/index.htm"",
      ""fullName"": ""Appalachian National Scenic Trail"",
      ""parkCode"": ""appa"",
      ""description"": ""The Appalachian Trail is a 2,190+ mile long public footpath that traverses the scenic, wooded, pastoral, wild, and culturally resonant lands of the Appalachian Mountains. Conceived in 1921, built by private citizens, and completed in 1937, today the trail is managed by the National Park Service, US Forest Service, Appalachian Trail Conservancy, numerous state agencies and thousands of volunteers."",
      ""latitude"": ""40.41029575"",
      ""longitude"": ""-76.4337548"",
      ""latLong"": ""lat:40.41029575, long:-76.4337548"",
      ""activities"": [
        {
          ""id"": ""13A57703-BB1A-41A2-94B8-53B692EB7238"",
          ""name"": ""Astronomy""
        },
        {
          ""id"": ""D37A0003-8317-4F04-8FB0-4CF0A272E195"",
          ""name"": ""Stargazing""
        },
        {
          ""id"": ""A59947B7-3376-49B4-AD02-C0423E08C5F7"",
          ""name"": ""Camping""
        },
        {
          ""id"": ""4A58AF13-E8FB-4530-B41A-97DF0B0C77B7"",
          ""name"": ""Backcountry Camping""
        },
        {
          ""id"": ""C11D3746-5063-4BD0-B245-7178D1AD866C"",
          ""name"": ""Compass and GPS""
        },
        {
          ""id"": ""89DA72D0-16D6-4C1C-89D4-103D94F1F63D"",
          ""name"": ""Orienteering""
        },
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""A0631906-9672-4583-91DE-113B93DB6B6E"",
          ""name"": ""Self-Guided Tours - Walking""
        },
        {
          ""id"": ""42FD78B9-2B90-4AA9-BC43-F10E9FEA8B5A"",
          ""name"": ""Hands-On""
        },
        {
          ""id"": ""31F88DA6-696F-441F-89CF-D7B1415C4CB9"",
          ""name"": ""Citizen Science""
        },
        {
          ""id"": ""9456A40A-AF75-4AD3-8BE1-79C4A7DBEDFC"",
          ""name"": ""Volunteer Vacation""
        },
        {
          ""id"": ""BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA"",
          ""name"": ""Hiking""
        },
        {
          ""id"": ""7C37B79B-D02D-49EB-9020-3DB8299B748A"",
          ""name"": ""Backcountry Hiking""
        },
        {
          ""id"": ""45261C0A-00D8-4C27-A1F8-029F933A0D34"",
          ""name"": ""Front-Country Hiking""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""01D717BC-18BB-4FE4-95BA-6B13AD702038"",
          ""name"": ""Snowshoeing""
        },
        {
          ""id"": ""0B685688-3405-4E2A-ABBA-E3069492EC50"",
          ""name"": ""Wildlife Watching""
        },
        {
          ""id"": ""5A2C91D1-50EC-4B24-8BED-A2E11A1892DF"",
          ""name"": ""Birdwatching""
        }
      ],
      ""topics"": [
        {
          ""id"": ""0D00073E-18C3-46E5-8727-2F87B112DDC6"",
          ""name"": ""Animals""
        },
        {
          ""id"": ""957EF2BD-AC6C-4B7B-BD9A-87593ADC6691"",
          ""name"": ""Birds""
        },
        {
          ""id"": ""EC707104-66CB-466F-90F8-76264F3BE578"",
          ""name"": ""Horses (wild)""
        },
        {
          ""id"": ""4DC11D06-00F1-4A01-81D0-89CCCCE4FF50"",
          ""name"": ""Climate Change""
        },
        {
          ""id"": ""41B1A0A3-11FF-4F55-9CB9-034A7E28B087"",
          ""name"": ""Forests and Woodlands""
        },
        {
          ""id"": ""762170E5-0747-4836-B837-7F2547D3F733"",
          ""name"": ""Coniferous Forests""
        },
        {
          ""id"": ""DE2F0F3C-C0C4-410F-90D3-97EEC33D348E"",
          ""name"": ""Deciduous Forests""
        },
        {
          ""id"": ""1CF1F6BB-A037-445B-8CF2-81428E50CE52"",
          ""name"": ""Lakes""
        },
        {
          ""id"": ""101F4D51-F99D-45A6-BBB6-CD481E5FACED"",
          ""name"": ""Mountains""
        },
        {
          ""id"": ""F8C2FE93-DEB3-4B12-9A87-913E3E6B448D"",
          ""name"": ""Natural Sounds""
        },
        {
          ""id"": ""A7359FC4-DAD8-45F5-AF15-7FF62F816ED3"",
          ""name"": ""Night Sky""
        },
        {
          ""id"": ""E06F3C94-AC8A-4B1C-A247-8EBA8910D5EE"",
          ""name"": ""Astronomy""
        },
        {
          ""id"": ""A155238F-0DD2-4610-9B87-05FCE1C59283"",
          ""name"": ""River and Riparian""
        },
        {
          ""id"": ""9C9FCBB6-360B-4743-8155-6F9341CBE01B"",
          ""name"": ""Scenic Views""
        },
        {
          ""id"": ""5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417"",
          ""name"": ""Trails""
        },
        {
          ""id"": ""BA12B386-49EA-46B0-9121-FCACACC47538"",
          ""name"": ""Watersheds""
        },
        {
          ""id"": ""54B56677-1200-4DF1-927C-36F389E04466"",
          ""name"": ""Headwaters""
        },
        {
          ""id"": ""5ED826E0-76BB-47BB-87DD-E081A72B0A04"",
          ""name"": ""Waterfalls""
        },
        {
          ""id"": ""1365C347-952C-475A-B755-731DD523C195"",
          ""name"": ""Wetlands""
        },
        {
          ""id"": ""B85866E2-0897-4000-9040-605CA335804F"",
          ""name"": ""Wilderness""
        }
      ],
      ""states"": ""CT,GA,MA,MD,ME,NC,NH,NJ,NY,PA,TN,VA,VT,WV"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""3045356278"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""0@0""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""There are many points of access along the Appalachian Trail, whether it is by car, train, bus or plane. For more detailed directions, please refer to the \""Directions\"" section of our park webpage."",
      ""directionsUrl"": ""http://www.nps.gov/appa/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [],
          ""description"": ""In general, the Appalachian Trail is open year-round. The northern terminus at Mount Katahdin in Maine is within Baxter State Park, which may be closed in winter months, depending on weather conditions. \nParticular sections of the Trail, and less-developed roads accessing the Trail, may be closed temporarily for a number of reasons, but otherwise the trail is open."",
          ""standardHours"": {
            ""wednesday"": ""All Day"",
            ""monday"": ""All Day"",
            ""thursday"": ""All Day"",
            ""sunday"": ""All Day"",
            ""tuesday"": ""All Day"",
            ""friday"": ""All Day"",
            ""saturday"": ""All Day""
          },
          ""name"": ""Appalachian National Scenic Trail""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""25425"",
          ""city"": ""Harpers Ferry"",
          ""stateCode"": ""WV"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""Appalachian Trail Park Office"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": ""P.O. Box 50""
        },
        {
          ""postalCode"": ""25425"",
          ""city"": ""Harpers Ferry"",
          ""stateCode"": ""WV"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""Appalachian Trail Park Office"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": ""P.O. Box 50""
        }
      ],
      ""images"": [
        {
          ""credit"": ""Photo Credit: ATC/Benjamin Hays"",
          ""title"": ""McAfee Knob"",
          ""altText"": ""Silhouette of a man with backpack standing on McAfee Knob at sunset with mountains in the distance."",
          ""caption"": ""McAfee Knob is one of the most popular locations along the A.T. to take photographs."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C8397D6-1DD8-B71B-0BEF4C54462A1EB3.jpg""
        },
        {
          ""credit"": ""Photo Credit: ATC"",
          ""title"": ""Appalachian Trail"",
          ""altText"": ""The Appalachian Trail runs across a mountain ridge line with views to the horizon of mountain range."",
          ""caption"": ""Crossing into thirteen states, hikers experience a variety of scenery along the way."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C83A128-1DD8-B71B-0B02DED286AFD8C6.jpg""
        },
        {
          ""credit"": ""Photo Credit: ATC/Matthew Davis"",
          ""title"": ""The Infamous White Blaze of the A.T."",
          ""altText"": ""A white blaze marks a tree in the foreground, with a man and child walking away on the wooded trail."",
          ""caption"": ""The white blaze marks the Appalachian Trail as a way for hikers to identify the route."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C83A2B0-1DD8-B71B-0B4589220F4D60D9.jpg""
        },
        {
          ""credit"": ""Photo Credit: Maine Appalachian Trail Club"",
          ""title"": ""Volunteer on the A.T."",
          ""altText"": ""A volunteer is carrying a split log while walking across a wooden footbridge in the woods."",
          ""caption"": ""The Appalachian Trail is maintained largely by volunteers."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C83A442-1DD8-B71B-0BD0A5F2BD69B9F6.jpg""
        },
        {
          ""credit"": ""Photo Credit: ATC/Greg Walter"",
          ""title"": ""Winter on the A.T."",
          ""altText"": ""A snowy winter view from the A.T. overlooking snowy mountains and clouds in the distance."",
          ""caption"": ""Hikers can experience many seasons along the A.T. all year round. It is important to be prepared."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C83A59A-1DD8-B71B-0BBFB87BBDDAABD6.jpg""
        }
      ],
      ""weatherInfo"": ""It is your responsibility to be prepared for all weather conditions, including extreme and unexpected weather changes year-round. As the trail runs from Georgia to Maine there will be different weather conditions depending on your location. For weather along specific sections of the trail and at specific shelters, please refer to: http://www.atweather.org/"",
      ""name"": ""Appalachian"",
      ""designation"": ""National Scenic Trail"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""A36366E7-5663-4531-B0CE-D58928C6D01B"",
      ""url"": ""https://www.nps.gov/blrv/index.htm"",
      ""fullName"": ""Blackstone River Valley National Historical Park"",
      ""parkCode"": ""blrv"",
      ""description"": ""The Blackstone River powered America's entry into the Age of Industry. The success of Samuel Slater's cotton spinning mill in Pawtucket, RI touched off a chain reaction that changed how people worked and where they lived. Learn how this revolution transformed the landscape of the Blackstone Valley and the United States. Old Slater Mill is open seasonally on Thursdays - Sundays starting on May 9."",
      ""latitude"": ""41.8775792792"",
      ""longitude"": ""-71.382433945"",
      ""latLong"": ""lat:41.8775792792, long:-71.382433945"",
      ""activities"": [
        {
          ""id"": ""7CE6E935-F839-4FEC-A63E-052B1DEF39D2"",
          ""name"": ""Biking""
        },
        {
          ""id"": ""AE42B46C-E4B7-4889-A122-08FE180371AE"",
          ""name"": ""Fishing""
        },
        {
          ""id"": ""1DFACD97-1B9C-4F5A-80F2-05593604799E"",
          ""name"": ""Food""
        },
        {
          ""id"": ""E53E1320-9B17-41DC-86A5-37EB7D622572"",
          ""name"": ""Dining""
        },
        {
          ""id"": ""C6D3230A-2CEA-4AFE-BFF3-DC1E2C2C4BB4"",
          ""name"": ""Picnicking""
        },
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""A0631906-9672-4583-91DE-113B93DB6B6E"",
          ""name"": ""Self-Guided Tours - Walking""
        },
        {
          ""id"": ""4D224BCA-C127-408B-AC75-A51563C42411"",
          ""name"": ""Paddling""
        },
        {
          ""id"": ""21DB3AFC-8AAC-4665-BC1F-7198C0685983"",
          ""name"": ""Canoeing""
        },
        {
          ""id"": ""F353A9ED-4A08-456E-8DEC-E61974D0FEB6"",
          ""name"": ""Kayaking""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""0B685688-3405-4E2A-ABBA-E3069492EC50"",
          ""name"": ""Wildlife Watching""
        },
        {
          ""id"": ""5A2C91D1-50EC-4B24-8BED-A2E11A1892DF"",
          ""name"": ""Birdwatching""
        }
      ],
      ""topics"": [
        {
          ""id"": ""69693007-2DF2-4EDE-BB3B-A25EBA72BDF5"",
          ""name"": ""Architecture and Building""
        },
        {
          ""id"": ""F3883A66-A7CB-461B-868E-1B5932224B25"",
          ""name"": ""American Revolution""
        },
        {
          ""id"": ""00F3C3F9-2D67-4802-81AE-CCEA5D3BA370"",
          ""name"": ""Arts""
        },
        {
          ""id"": ""DAAD7F5E-9112-45F2-9A27-DA51B639F27E"",
          ""name"": ""Dams""
        },
        {
          ""id"": ""1F833C99-A75D-4F9E-9256-B96523485466"",
          ""name"": ""Farming and  Agriculture""
        },
        {
          ""id"": ""14FA9FF3-7D86-4406-9A6D-BE9032A1C578"",
          ""name"": ""Laborer and Worker""
        },
        {
          ""id"": ""BEB7E470-13B2-4E00-84B2-0402D98DAF69"",
          ""name"": ""Monuments and Memorials""
        },
        {
          ""id"": ""3CDB67A9-1EAC-408D-88EC-F26FA35E90AF"",
          ""name"": ""Schools and Education""
        },
        {
          ""id"": ""FE2C2613-B41E-4531-BC43-03EB6E45CBCF"",
          ""name"": ""Transportation""
        },
        {
          ""id"": ""1015393C-D7B0-47F3-86FB-786F30368CA2"",
          ""name"": ""Bridges""
        },
        {
          ""id"": ""9749E14B-ED9A-4E86-BAEA-CAC7B718F266"",
          ""name"": ""Canals""
        },
        {
          ""id"": ""0BBD4A42-2B3D-4E82-B5C4-1A3874C8682E"",
          ""name"": ""Roads, Routes and Highways""
        },
        {
          ""id"": ""86525CF5-EB56-41A6-90BF-566C6C0FC945"",
          ""name"": ""Trains and Railroads""
        },
        {
          ""id"": ""846E5C56-E5AC-489C-B3BF-11F4C73F12C2"",
          ""name"": ""Urban America""
        },
        {
          ""id"": ""0D00073E-18C3-46E5-8727-2F87B112DDC6"",
          ""name"": ""Animals""
        },
        {
          ""id"": ""957EF2BD-AC6C-4B7B-BD9A-87593ADC6691"",
          ""name"": ""Birds""
        },
        {
          ""id"": ""1608649A-E7D7-4529-BD83-074C90F9FB68"",
          ""name"": ""Fish""
        },
        {
          ""id"": ""393F60FB-80D6-46F7-B0FB-BBF3C90F59FD"",
          ""name"": ""Tortoises and Turtles""
        },
        {
          ""id"": ""4DC11D06-00F1-4A01-81D0-89CCCCE4FF50"",
          ""name"": ""Climate Change""
        },
        {
          ""id"": ""9F6A7003-59D6-4438-935F-760FD04C1073"",
          ""name"": ""Foothills, Plains and Valleys""
        },
        {
          ""id"": ""41B1A0A3-11FF-4F55-9CB9-034A7E28B087"",
          ""name"": ""Forests and Woodlands""
        },
        {
          ""id"": ""F8C2FE93-DEB3-4B12-9A87-913E3E6B448D"",
          ""name"": ""Natural Sounds""
        },
        {
          ""id"": ""9C9FCBB6-360B-4743-8155-6F9341CBE01B"",
          ""name"": ""Scenic Views""
        },
        {
          ""id"": ""5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417"",
          ""name"": ""Trails""
        },
        {
          ""id"": ""596BAA6D-F66B-4348-8433-FEFF35A8005E"",
          ""name"": ""Water Trails""
        },
        {
          ""id"": ""BA12B386-49EA-46B0-9121-FCACACC47538"",
          ""name"": ""Watersheds""
        }
      ],
      ""states"": ""RI,MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""401-725-8638"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""blrv_info@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""The park headquarters is located at the Wilkinson Mill in the Historic Slater Mill Complex in Pawtucket, RI. 67 Roosevelt Avenue Pawtucket, RI 02860 401-428-3816"",
      ""directionsUrl"": ""http://nps.gov/blrv/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [],
          ""description"": ""The park grounds are open from Sunrise to Sunset.  \n\nThe headquarters are located at Slater Mill\n67 Roosevelt Ave\nPawtucket, RI 02860\n\n401-521-7266"",
          ""standardHours"": {
            ""wednesday"": ""Sunrise to Sunset"",
            ""monday"": ""Sunrise to Sunset"",
            ""thursday"": ""Sunrise to Sunset"",
            ""sunday"": ""Sunrise to Sunset"",
            ""tuesday"": ""Sunrise to Sunset"",
            ""friday"": ""Sunrise to Sunset"",
            ""saturday"": ""Sunrise to Sunset""
          },
          ""name"": ""Blackstone River Valley National Historical Park""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""02860"",
          ""city"": ""Pawtucket"",
          ""stateCode"": ""RI"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""67 Roosevelt Ave"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": """"
        },
        {
          ""postalCode"": ""02860"",
          ""city"": ""Pawtucket"",
          ""stateCode"": ""RI"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""67 Roosevelt Ave"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": """"
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Slater Mill Site"",
          ""altText"": ""Slater Mill, Wilkinson Mill and Brown House at Blackstone River Valley NHP"",
          ""caption"": ""Slater Mill, Wilkinson Mill and Brown House at Blackstone River Valley NHP"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/0BD0215D-B0D9-7E37-CFF0CDB2B29679CC.png""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Slatersville"",
          ""altText"": ""Slatersville"",
          ""caption"": ""View of John Slater's home in Slatersville, RI"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7BD3C0-1DD8-B71B-0BDD87BD4E0070A2.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Ashton Kelly House and canal"",
          ""altText"": ""Blackstone canal outside of the Wilbur Kelly House"",
          ""caption"": ""The Blackstone Canal and towpath along the Wilbur Kelly House in Ashton, RI"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7BD04E-1DD8-B71B-0B3A6A73F3DA415B.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Little Red Shop"",
          ""altText"": ""The Little Red Shop in Hopedale, MA"",
          ""caption"": ""The Little Red Shop in Hopedale, MA - the original home of the Draper Loom Corporation"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7BD1EB-1DD8-B71B-0BB6BD446709EF5D.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Wilkinson Mill interior"",
          ""altText"": ""Interior view of the Wilkinson Mill"",
          ""caption"": ""The machine shop inside the Wilkinson Mill"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7BD559-1DD8-B71B-0B165454D6F7D0B6.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Autumn in the Blackstone Valley"",
          ""altText"": ""Autumn in the Blackstone Valley"",
          ""caption"": ""Autumn in the Blackstone Valley"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7BD6A6-1DD8-B71B-0BB41BBE33806A03.jpg""
        }
      ],
      ""weatherInfo"": ""Summer temperatures range from 56-83F. Fall temperatures range from 30-70F. Winter temperatures range from 20-45F. Spring temperatures range from 30-70F."",
      ""name"": ""Blackstone River Valley"",
      ""designation"": ""National Historical Park"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""87F00684-8E1F-4E12-B463-2B5B929A0C74"",
      ""url"": ""https://www.nps.gov/boaf/index.htm"",
      ""fullName"": ""Boston African American National Historic Site"",
      ""parkCode"": ""boaf"",
      ""description"": ""Centered on the north slope of Beacon Hill, the African American community of 1800s Boston led the city and the nation in the fight against slavery and injustice. These remarkable men and women, together with their allies, were leaders in the Abolition Movement, the Underground Railroad, the Civil War, and the early struggle for equal rights and education."",
      ""latitude"": ""42.35908295"",
      ""longitude"": ""-71.06764181"",
      ""latLong"": ""lat:42.35908295, long:-71.06764181"",
      ""activities"": [
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""A0631906-9672-4583-91DE-113B93DB6B6E"",
          ""name"": ""Self-Guided Tours - Walking""
        },
        {
          ""id"": ""C8F98B28-3C10-41AE-AA99-092B3B398C43"",
          ""name"": ""Museum Exhibits""
        }
      ],
      ""topics"": [
        {
          ""id"": ""28AEAE85-9DDA-45B6-981B-1CFCDCC61E14"",
          ""name"": ""African American Heritage""
        },
        {
          ""id"": ""D9FC6D14-F8C7-4EBA-86EA-DFD99B6BB4F5"",
          ""name"": ""Enslavement""
        },
        {
          ""id"": ""E0AB480F-3A94-4DC1-8B21-9555F2C59B32"",
          ""name"": ""LGBTQ American Heritage""
        },
        {
          ""id"": ""3B0D607D-9933-425A-BFA0-21529AC4734C"",
          ""name"": ""Military""
        },
        {
          ""id"": ""97CCB419-196C-4B95-BB3A-621458F78415"",
          ""name"": ""US Army""
        },
        {
          ""id"": ""518B32FB-339D-4C52-B2C2-04BF406AA4B0"",
          ""name"": ""Religion and Spirituality""
        },
        {
          ""id"": ""98F41FDF-B73F-4B68-8010-53CCB2891E3B"",
          ""name"": ""Churches""
        },
        {
          ""id"": ""40C0866A-3890-41A4-84CA-5935DEE181AE"",
          ""name"": ""Social Movements""
        },
        {
          ""id"": ""5CCB14BC-2AC4-45CE-B786-54A065DA1B60"",
          ""name"": ""Abolition Movement""
        },
        {
          ""id"": ""27BF8807-54EA-4A3D-B073-AA7AA361CD7E"",
          ""name"": ""Wars and Conflicts""
        },
        {
          ""id"": ""A8E54356-20CD-490E-B34D-AC6A430E6F47"",
          ""name"": ""Civil War""
        },
        {
          ""id"": ""4DC11D06-00F1-4A01-81D0-89CCCCE4FF50"",
          ""name"": ""Climate Change""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""6174296760"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": ""Please use this email for general inquiries."",
            ""emailAddress"": ""boaf_mail@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""Site administrative offices are located at 15 State Street. However, Ranger programs begin at either the Robert Gould Shaw Memorial on Beacon Street, or at the Museum of African American History at 46 Joy Street on Beacon Hill."",
      ""directionsUrl"": ""http://www.nps.gov/boaf/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {},
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {},
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {},
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Year's Day"",
              ""endDate"": ""2025-01-01""
            }
          ],
          ""description"": ""Boston African American National Historic Site rangers offer tours of the Black Heritage Trail seasonally. Please check the park calendar for available tours and programs."",
          ""standardHours"": {
            ""wednesday"": ""10:00AM - 4:00PM"",
            ""monday"": ""Closed"",
            ""thursday"": ""10:00AM - 4:00PM"",
            ""sunday"": ""10:00AM - 4:00PM"",
            ""tuesday"": ""10:00AM - 4:00PM"",
            ""friday"": ""10:00AM - 4:00PM"",
            ""saturday"": ""10:00AM - 4:00PM""
          },
          ""name"": ""Boston African American National Historic Site""
        },
        {
          ""exceptions"": [],
          ""description"": ""The Museum of African American History is a partner of Boston African American National Historic Site. They operate the Abiel Smith School and the African Meeting House in conjunction with the National Park Service."",
          ""standardHours"": {
            ""wednesday"": ""10:00AM - 4:00PM"",
            ""monday"": ""Closed"",
            ""thursday"": ""10:00AM - 4:00PM"",
            ""sunday"": ""10:00AM - 4:00PM"",
            ""tuesday"": ""10:00AM - 4:00PM"",
            ""friday"": ""10:00AM - 4:00PM"",
            ""saturday"": ""10:00AM - 4:00PM""
          },
          ""name"": ""Museum of African American History""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""02109"",
          ""city"": ""Boston"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""15 State Street"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": ""Boston African American National Historical Site""
        },
        {
          ""postalCode"": ""02109"",
          ""city"": ""Boston"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""15 State Street"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": ""Boston African American National Historical Site""
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""The African Meeting House"",
          ""altText"": ""View from the pulpit at the African Meeting House"",
          ""caption"": ""The African Meeting House served as the religious, educational, and political center of Boston's 19th century African American community."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C790A8C-1DD8-B71B-0BB037E9568998D1.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""The William Cooper Nell House"",
          ""altText"": ""A yellow wooden house on Beacon Hill"",
          ""caption"": ""This is the home of education activist, abolitionist, and historian William Cooper Nell."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C790CB4-1DD8-B71B-0B29F4B5171A78B3.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""The Robert Gould Shaw Memorial"",
          ""altText"": ""A large bronze statue showing a man on horseback and soldiers walking alongside him"",
          ""caption"": ""The Robert Gould Shaw Memorial honors Colonel Shaw and the Massachusetts 54th, the first African American regiment from the North to fight in the Civil War."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C791129-1DD8-B71B-0B2415095E720C42.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Flowers at the Shaw Memorial"",
          ""altText"": ""A close up image of flowers laid at the feet of the soldiers on the Shaw Memorial"",
          ""caption"": ""Flowers laid at the feet of the soldiers on the Robert Gould Shaw Memorial."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C79121E-1DD8-B71B-0BCA364A0C215DA4.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""The Lewis and Harriet Hayden House"",
          ""altText"": ""The entrance door into a red brick townhouse on Beacon Hill"",
          ""caption"": ""Lewis and Harriet Hayden used their home as an Underground Railroad safe house to shelter those running away from slavery."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C791807-1DD8-B71B-0B5F48E02243E9C0.jpg""
        }
      ],
      ""weatherInfo"": ""Boston African American National Historic Site is located in downtown Boston which can see extreme cold in the winter months, as well as extreme heat and humidity throughout the summer months. Walking tours may be cancelled during severe heat and/or weather events."",
      ""name"": ""Boston African American"",
      ""designation"": ""National Historic Site"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""65E0DF4A-4082-4B48-93BD-5021987CDD7A"",
      ""url"": ""https://www.nps.gov/boha/index.htm"",
      ""fullName"": ""Boston Harbor Islands National Recreation Area"",
      ""parkCode"": ""boha"",
      ""description"": "". . . where you can walk a Civil War-era fort, visit historic lighthouses, explore tide pools, hike lush trails, camp under the stars, or relax while fishing, picnicking or swimming-all within reach of downtown Boston. Youth programs, visitor services, research, wildlife management, and more are coordinated on the park's 34 islands and peninsulas by the Boston Harbor Islands Partnership."",
      ""latitude"": ""42.30905526"",
      ""longitude"": ""-70.93941138"",
      ""latLong"": ""lat:42.30905526, long:-70.93941138"",
      ""activities"": [
        {
          ""id"": ""09DF0950-D319-4557-A57E-04CD2F63FF42"",
          ""name"": ""Arts and Culture""
        },
        {
          ""id"": ""C0FFC3D5-0E74-4B6F-B69D-6F95B78906CE"",
          ""name"": ""Live Music""
        },
        {
          ""id"": ""071BA73C-1D3C-46D4-A53C-00D5602F7F0E"",
          ""name"": ""Boating""
        },
        {
          ""id"": ""A59947B7-3376-49B4-AD02-C0423E08C5F7"",
          ""name"": ""Camping""
        },
        {
          ""id"": ""4A58AF13-E8FB-4530-B41A-97DF0B0C77B7"",
          ""name"": ""Backcountry Camping""
        },
        {
          ""id"": ""907E8125-15E4-483C-8EAD-B9FA1E85C6F8"",
          ""name"": ""Canoe or Kayak Camping""
        },
        {
          ""id"": ""AE42B46C-E4B7-4889-A122-08FE180371AE"",
          ""name"": ""Fishing""
        },
        {
          ""id"": ""17411C8D-5769-4D0F-ABD1-52ED03840C18"",
          ""name"": ""Saltwater Fishing""
        },
        {
          ""id"": ""1DFACD97-1B9C-4F5A-80F2-05593604799E"",
          ""name"": ""Food""
        },
        {
          ""id"": ""E53E1320-9B17-41DC-86A5-37EB7D622572"",
          ""name"": ""Dining""
        },
        {
          ""id"": ""C6D3230A-2CEA-4AFE-BFF3-DC1E2C2C4BB4"",
          ""name"": ""Picnicking""
        },
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""A0631906-9672-4583-91DE-113B93DB6B6E"",
          ""name"": ""Self-Guided Tours - Walking""
        },
        {
          ""id"": ""BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA"",
          ""name"": ""Hiking""
        },
        {
          ""id"": ""B204DE60-5A24-43DD-8902-C81625A09A74"",
          ""name"": ""Living History""
        },
        {
          ""id"": ""4D224BCA-C127-408B-AC75-A51563C42411"",
          ""name"": ""Paddling""
        },
        {
          ""id"": ""F353A9ED-4A08-456E-8DEC-E61974D0FEB6"",
          ""name"": ""Kayaking""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""0B685688-3405-4E2A-ABBA-E3069492EC50"",
          ""name"": ""Wildlife Watching""
        },
        {
          ""id"": ""5A2C91D1-50EC-4B24-8BED-A2E11A1892DF"",
          ""name"": ""Birdwatching""
        }
      ],
      ""topics"": [
        {
          ""id"": ""F3883A66-A7CB-461B-868E-1B5932224B25"",
          ""name"": ""American Revolution""
        },
        {
          ""id"": ""7F81A0CB-B91F-4896-B9A5-41BE9A54A27B"",
          ""name"": ""Archeology""
        },
        {
          ""id"": ""607D41B0-F830-4C07-A557-BCEF880A3929"",
          ""name"": ""Burial, Cemetery and Gravesite""
        },
        {
          ""id"": ""7F12224B-217A-4B07-A4A2-636B1CE7F221"",
          ""name"": ""Colonization and Settlement""
        },
        {
          ""id"": ""D9FC6D14-F8C7-4EBA-86EA-DFD99B6BB4F5"",
          ""name"": ""Enslavement""
        },
        {
          ""id"": ""988B4AFC-F478-4673-B66D-E6BDB0CCFF35"",
          ""name"": ""Forts""
        },
        {
          ""id"": ""4C9D4777-A9DA-47D1-A0B9-F4A3C98BC1B3"",
          ""name"": ""Maritime""
        },
        {
          ""id"": ""123CE28E-0EFA-4330-8E6E-EEFF3D7BF772"",
          ""name"": ""Coastal Defenses""
        },
        {
          ""id"": ""7424754D-EB8B-4608-A69A-50D44992931B"",
          ""name"": ""Maritime - Military""
        },
        {
          ""id"": ""263BAC6E-4DEC-47E4-909D-DA8AD351E06E"",
          ""name"": ""Lighthouses""
        },
        {
          ""id"": ""78CF2074-0EE5-48F1-AD0F-B39C6C5A447B"",
          ""name"": ""Piracy and Privateering""
        },
        {
          ""id"": ""4B3CD083-7500-434B-A8C2-D355925E0245"",
          ""name"": ""Medicine""
        },
        {
          ""id"": ""97716EF5-D001-449C-993A-EC15AB8FD345"",
          ""name"": ""Hospital""
        },
        {
          ""id"": ""3B0D607D-9933-425A-BFA0-21529AC4734C"",
          ""name"": ""Military""
        },
        {
          ""id"": ""97CCB419-196C-4B95-BB3A-621458F78415"",
          ""name"": ""US Army""
        },
        {
          ""id"": ""BEB7E470-13B2-4E00-84B2-0402D98DAF69"",
          ""name"": ""Monuments and Memorials""
        },
        {
          ""id"": ""A1BAF33E-EA84-4608-A888-4CEE9541F027"",
          ""name"": ""Native American Heritage""
        },
        {
          ""id"": ""40C0866A-3890-41A4-84CA-5935DEE181AE"",
          ""name"": ""Social Movements""
        },
        {
          ""id"": ""5CCB14BC-2AC4-45CE-B786-54A065DA1B60"",
          ""name"": ""Abolition Movement""
        },
        {
          ""id"": ""27BF8807-54EA-4A3D-B073-AA7AA361CD7E"",
          ""name"": ""Wars and Conflicts""
        },
        {
          ""id"": ""A8E54356-20CD-490E-B34D-AC6A430E6F47"",
          ""name"": ""Civil War""
        },
        {
          ""id"": ""0D00073E-18C3-46E5-8727-2F87B112DDC6"",
          ""name"": ""Animals""
        },
        {
          ""id"": ""957EF2BD-AC6C-4B7B-BD9A-87593ADC6691"",
          ""name"": ""Birds""
        },
        {
          ""id"": ""1608649A-E7D7-4529-BD83-074C90F9FB68"",
          ""name"": ""Fish""
        },
        {
          ""id"": ""46FC5CBD-9AD5-48F1-B4DA-1357031B1D2E"",
          ""name"": ""Coasts, Islands and Atolls""
        },
        {
          ""id"": ""0E6D8503-CB65-467F-BCD6-C6D9E28A4E0B"",
          ""name"": ""Oceans""
        },
        {
          ""id"": ""9C9FCBB6-360B-4743-8155-6F9341CBE01B"",
          ""name"": ""Scenic Views""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""6172238666"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""BOHA_Information@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""There are many ways to enjoy Boston Harbor Islands and many ways to get there. For more information on how to get to the park by ferry, car, or private boat, please visit www.bostonharborislands.org."",
      ""directionsUrl"": ""http://www.nps.gov/boha/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2023-10-15"",
              ""name"": ""Winter"",
              ""endDate"": ""2024-05-17""
            }
          ],
          ""description"": ""Boston Harbor Islands is a Partnership park. Operating hours and seasons vary.\n\nVisit bostonharborislands.org to plan your trip."",
          ""standardHours"": {
            ""wednesday"": ""All Day"",
            ""monday"": ""All Day"",
            ""thursday"": ""All Day"",
            ""sunday"": ""All Day"",
            ""tuesday"": ""All Day"",
            ""friday"": ""All Day"",
            ""saturday"": ""All Day""
          },
          ""name"": ""Boston Harbor Islands""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""02109"",
          ""city"": ""Boston"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""15 State Street"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": ""4th Floor""
        },
        {
          ""postalCode"": ""02109"",
          ""city"": ""Boston"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""15 State Street"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": ""4th Floor""
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Beach Dancing"",
          ""altText"": ""A child dancing on the beach at dusk"",
          ""caption"": ""A child dancing on the beach at dusk"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C858BDF-1DD8-B71B-0B6D6FFEF068BAB3.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Kayaking Boston Harbor Islands"",
          ""altText"": ""A man on a kayak in Boston Harbor"",
          ""caption"": ""Kayaking in Boston Harbor Islands National Recreational Area"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C858CF8-1DD8-B71B-0B6F55E56150332B.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Sunset Over Boston"",
          ""altText"": ""An image of the sun setting over the Boston skyline from the Islands"",
          ""caption"": ""Watch the sunset from Boston Harbor Islands"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C858E65-1DD8-B71B-0B1107E16289DA49.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Come Explore The Islands"",
          ""altText"": ""Children looking out at Boston from the Harbor Islands"",
          ""caption"": ""Looking out at the city from the Boston Harbor Islands"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C858F6B-1DD8-B71B-0B9C8D905FF4A7E9.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Fort Warren"",
          ""altText"": ""Historic Fort Warren on Georges Island"",
          ""caption"": ""Visit historic Fort Warren on Georges Island in Boston Harbor"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C85906D-1DD8-B71B-0BA5582CA1AEF263.jpg""
        }
      ],
      ""weatherInfo"": ""The Boston Harbor Islands have a humid maritime climate characterized by slightly cooler temperatures than the mainland, so dress in layers. Typical summer conditions feature air temperatures approximately 5-10 degrees cooler than the mainland between 60-80 Fahrenheit, winds of 0-15 knots and waves of 1-3 feet."",
      ""name"": ""Boston Harbor Islands"",
      ""designation"": ""National Recreation Area"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""81F81EBD-0FE7-4811-88EF-AB071E737D97"",
      ""url"": ""https://www.nps.gov/bost/index.htm"",
      ""fullName"": ""Boston National Historical Park"",
      ""parkCode"": ""bost"",
      ""description"": ""Discover how one city could be the Cradle of Liberty, site of the first major battle of American Revolution, and home to many who espoused that freedom can be extended to all."",
      ""latitude"": ""42.36957407"",
      ""longitude"": ""-71.05536763"",
      ""latLong"": ""lat:42.36957407, long:-71.05536763"",
      ""activities"": [
        {
          ""id"": ""AE42B46C-E4B7-4889-A122-08FE180371AE"",
          ""name"": ""Fishing""
        },
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""A0631906-9672-4583-91DE-113B93DB6B6E"",
          ""name"": ""Self-Guided Tours - Walking""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""C8F98B28-3C10-41AE-AA99-092B3B398C43"",
          ""name"": ""Museum Exhibits""
        }
      ],
      ""topics"": [
        {
          ""id"": ""F3883A66-A7CB-461B-868E-1B5932224B25"",
          ""name"": ""American Revolution""
        },
        {
          ""id"": ""14FA9FF3-7D86-4406-9A6D-BE9032A1C578"",
          ""name"": ""Laborer and Worker""
        },
        {
          ""id"": ""E0AB480F-3A94-4DC1-8B21-9555F2C59B32"",
          ""name"": ""LGBTQ American Heritage""
        },
        {
          ""id"": ""4C9D4777-A9DA-47D1-A0B9-F4A3C98BC1B3"",
          ""name"": ""Maritime""
        },
        {
          ""id"": ""7424754D-EB8B-4608-A69A-50D44992931B"",
          ""name"": ""Maritime - Military""
        },
        {
          ""id"": ""3B0D607D-9933-425A-BFA0-21529AC4734C"",
          ""name"": ""Military""
        },
        {
          ""id"": ""E411F474-A530-4804-9D23-1D94C78B41E4"",
          ""name"": ""Infantry and Militia""
        },
        {
          ""id"": ""7A9F5EB5-4AE3-4A16-AFF0-E1F9FF2F8B32"",
          ""name"": ""US Navy""
        },
        {
          ""id"": ""6A3658B4-FB6E-4E23-A63A-9AEF11988831"",
          ""name"": ""Battlefields""
        },
        {
          ""id"": ""BEB7E470-13B2-4E00-84B2-0402D98DAF69"",
          ""name"": ""Monuments and Memorials""
        },
        {
          ""id"": ""40C0866A-3890-41A4-84CA-5935DEE181AE"",
          ""name"": ""Social Movements""
        },
        {
          ""id"": ""5CCB14BC-2AC4-45CE-B786-54A065DA1B60"",
          ""name"": ""Abolition Movement""
        },
        {
          ""id"": ""DA1E6678-D60D-4E66-96A5-78183342673B"",
          ""name"": ""Voting Rights and Suffrage""
        },
        {
          ""id"": ""27BF8807-54EA-4A3D-B073-AA7AA361CD7E"",
          ""name"": ""Wars and Conflicts""
        },
        {
          ""id"": ""990E22A2-20D8-4CC2-8E6C-D2DF165BCDA5"",
          ""name"": ""American Revolutionary War""
        },
        {
          ""id"": ""74869FAE-8DFD-4454-847F-11FDDB679F94"",
          ""name"": ""World War II""
        },
        {
          ""id"": ""7DA81DAB-5045-4953-9C20-36590AD9FA95"",
          ""name"": ""Women's History""
        },
        {
          ""id"": ""4DC11D06-00F1-4A01-81D0-89CCCCE4FF50"",
          ""name"": ""Climate Change""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""6172425601"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""BOST_Email@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""Visitor Centers are located at Historic Faneuil Hall, 1 Faneuil Hall Sq, and the Charlestown Navy Yard, Building 5. Go to the Directions page for more detailed information."",
      ""directionsUrl"": ""http://www.nps.gov/bost/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving Day"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Year's Day"",
              ""endDate"": ""2025-01-01""
            }
          ],
          ""description"": ""Boston National Historical Park is a unique collaboration of federally, municipally, and privately owned and operated historic sites. Most of the park is along Boston's Freedom Trail�, a 2.5 mile (4 km) walking path marked by a red brick or painted line weaving through Downtown Boston, the North End, and Charlestown.\n\nThe trail itself is outdoors and open year round. Every site along the trail has its own hours which vary throughout the season. Please check ahead before planning your visit."",
          ""standardHours"": {
            ""wednesday"": ""9:00AM - 5:00PM"",
            ""monday"": ""9:00AM - 5:00PM"",
            ""thursday"": ""9:00AM - 5:00PM"",
            ""sunday"": ""9:00AM - 5:00PM"",
            ""tuesday"": ""9:00AM - 5:00PM"",
            ""friday"": ""9:00AM - 5:00PM"",
            ""saturday"": ""9:00AM - 5:00PM""
          },
          ""name"": ""Boston National Historical Park""
        },
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""1:00PM - 4:00PM"",
                ""monday"": ""Closed"",
                ""thursday"": ""1:00PM - 4:00PM"",
                ""sunday"": ""1:00PM - 4:00PM"",
                ""tuesday"": ""Closed"",
                ""friday"": ""1:00PM - 4:00PM"",
                ""saturday"": ""1:00PM - 4:00PM""
              },
              ""startDate"": ""2024-01-03"",
              ""name"": ""Winter 2024 Hours"",
              ""endDate"": ""2024-05-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""10:00AM - 5:30AM"",
                ""monday"": ""Closed"",
                ""thursday"": ""10:00AM - 5:30PM"",
                ""sunday"": ""10:00AM - 5:30PM"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Opens at 10:00AM"",
                ""saturday"": ""10:00AM - 5:30PM""
              },
              ""startDate"": ""2024-06-30"",
              ""name"": ""Summer"",
              ""endDate"": ""2024-11-11""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving Day"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Year's Day"",
              ""endDate"": ""2025-01-01""
            }
          ],
          ""description"": ""Please note: Only 20 people are allowed in the Monument at a time.\n\nBe advised: The Monument may close for climbing due to weather conditions and/or other safety considerations."",
          ""standardHours"": {
            ""wednesday"": ""10:00AM - 4:30PM"",
            ""monday"": ""Closed"",
            ""thursday"": ""10:00AM - 4:30PM"",
            ""sunday"": ""10:00AM - 4:30PM"",
            ""tuesday"": ""Closed"",
            ""friday"": ""10:00AM - 4:30PM"",
            ""saturday"": ""10:00AM - 4:30PM""
          },
          ""name"": ""Bunker Hill Monument""
        },
        {
          ""exceptions"": [],
          ""description"": ""Dorchester Heights marks the site of George Washington's first Revolutionary War victory. Located atop the last remaining hill in South Boston fortified by the Continental Army, the park grounds are open from dawn to dusk. The monument is currently not open to the public."",
          ""standardHours"": {
            ""wednesday"": ""Sunrise to Sunset"",
            ""monday"": ""Sunrise to Sunset"",
            ""thursday"": ""Sunrise to Sunset"",
            ""sunday"": ""Sunrise to Sunset"",
            ""tuesday"": ""Sunrise to Sunset"",
            ""friday"": ""Sunrise to Sunset"",
            ""saturday"": ""Sunrise to Sunset""
          },
          ""name"": ""Dorchester Heights""
        },
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""10:00AM - 4:15PM"",
                ""monday"": ""10:00AM - 4:15PM"",
                ""thursday"": ""10:00AM - 4:15PM"",
                ""sunday"": ""10:00AM - 4:15PM"",
                ""tuesday"": ""10:00AM - 4:15PM"",
                ""friday"": ""10:00AM - 4:15PM"",
                ""saturday"": ""10:00AM - 4:15PM""
              },
              ""startDate"": ""2024-11-01"",
              ""name"": ""November to Mid-December Hours"",
              ""endDate"": ""2024-12-18""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving Day"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""10:00AM - 4:15PM"",
                ""monday"": ""Closed"",
                ""thursday"": ""10:00AM - 4:15PM"",
                ""sunday"": ""10:00AM - 4:15PM"",
                ""tuesday"": ""10:00AM - 4:15PM"",
                ""friday"": ""10:00AM - 4:15PM"",
                ""saturday"": ""10:00AM - 4:15PM""
              },
              ""startDate"": ""2024-12-18"",
              ""name"": ""Winter Hours"",
              ""endDate"": ""2025-03-31""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-24"",
              ""name"": ""Christmas Eve"",
              ""endDate"": ""2024-12-24""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Year's Day"",
              ""endDate"": ""2025-01-01""
            }
          ],
          ""description"": ""The Paul Revere House is a Boston National Historical Park partner site operated by the Paul Revere Memorial Association."",
          ""standardHours"": {
            ""wednesday"": ""10:00AM - 5:15PM"",
            ""monday"": ""10:00AM - 5:15PM"",
            ""thursday"": ""10:00AM - 5:15PM"",
            ""sunday"": ""10:00AM - 5:15PM"",
            ""tuesday"": ""10:00AM - 5:15PM"",
            ""friday"": ""10:00AM - 5:15PM"",
            ""saturday"": ""10:00AM - 5:15PM""
          },
          ""name"": ""Paul Revere House""
        },
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""Winter 2024"",
              ""endDate"": ""2025-02-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""10:00AM - 5:00PM"",
                ""monday"": ""Closed"",
                ""thursday"": ""10:00AM - 5:00PM"",
                ""sunday"": ""12:30PM - 5:00PM"",
                ""tuesday"": ""10:00AM - 5:00PM"",
                ""friday"": ""10:00AM - 5:00PM"",
                ""saturday"": ""10:00AM - 5:00PM""
              },
              ""startDate"": ""2024-03-01"",
              ""name"": ""Spring 2024"",
              ""endDate"": ""2024-06-30""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""10:00AM - 5:00PM"",
                ""monday"": ""10:00AM - 5:00PM"",
                ""thursday"": ""10:00AM - 5:00PM"",
                ""sunday"": ""10:00AM - 5:00PM"",
                ""tuesday"": ""10:00AM - 5:00PM"",
                ""friday"": ""10:00AM - 5:00PM"",
                ""saturday"": ""10:00AM - 5:00PM""
              },
              ""startDate"": ""2024-05-27"",
              ""name"": ""Memorial Day"",
              ""endDate"": ""2024-05-27""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""11:00AM - 5:00PM"",
                ""monday"": ""Closed"",
                ""thursday"": ""11:00AM - 5:00PM"",
                ""sunday"": ""12:30PM - 5:00PM"",
                ""tuesday"": ""11:00AM - 5:00PM"",
                ""friday"": ""11:00AM - 5:00PM"",
                ""saturday"": ""11:00AM - 5:00PM""
              },
              ""startDate"": ""2024-11-01"",
              ""name"": ""Fall 2024"",
              ""endDate"": ""2024-12-31""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving Day"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-24"",
              ""name"": ""Christmas Eve"",
              ""endDate"": ""2024-12-24""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""10:00AM - 2:00PM"",
                ""monday"": ""10:00AM - 2:00PM"",
                ""thursday"": ""10:00AM - 2:00PM"",
                ""sunday"": ""10:00AM - 2:00PM"",
                ""tuesday"": ""10:00AM - 2:00PM"",
                ""friday"": ""10:00AM - 2:00PM"",
                ""saturday"": ""10:00AM - 2:00PM""
              },
              ""startDate"": ""2024-12-31"",
              ""name"": ""New Year's Eve"",
              ""endDate"": ""2024-12-31""
            }
          ],
          ""description"": ""Old North is a Boston National Historical Park partner site operated by Old North Illuminated."",
          ""standardHours"": {
            ""wednesday"": ""10:00AM - 5:00PM"",
            ""monday"": ""10:00AM - 5:00PM"",
            ""thursday"": ""10:00AM - 5:00PM"",
            ""sunday"": ""11:30AM - 5:00PM"",
            ""tuesday"": ""10:00AM - 5:00PM"",
            ""friday"": ""10:00AM - 5:00PM"",
            ""saturday"": ""10:00AM - 5:00PM""
          },
          ""name"": ""Old North Church""
        },
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving Day"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-24"",
              ""name"": ""Christmas Eve"",
              ""endDate"": ""2024-12-24""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Year's Day"",
              ""endDate"": ""2025-01-01""
            }
          ],
          ""description"": ""The Old State House is a Boston National Historical Park partner site operated by Revolutionary Spaces.\n\nFor more visitor information, please visit the Revolutionary Spaces website."",
          ""standardHours"": {
            ""wednesday"": ""10:00AM - 5:00PM"",
            ""monday"": ""10:00AM - 5:00PM"",
            ""thursday"": ""10:00AM - 5:00PM"",
            ""sunday"": ""10:00AM - 5:00PM"",
            ""tuesday"": ""10:00AM - 5:00PM"",
            ""friday"": ""10:00AM - 5:00PM"",
            ""saturday"": ""10:00AM - 5:00PM""
          },
          ""name"": ""Old State House""
        },
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving Day"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-24"",
              ""name"": ""Christmas Eve"",
              ""endDate"": ""2024-12-24""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Year's Day"",
              ""endDate"": ""2025-01-01""
            }
          ],
          ""description"": ""The Old South Meeting House is a Boston National Historical Park partner site operated by Revolutionary Spaces.\n\nFor more visitor information, please visit the Revolutionary Spaces website."",
          ""standardHours"": {
            ""wednesday"": ""10:00AM - 5:00PM"",
            ""monday"": ""10:00AM - 5:00PM"",
            ""thursday"": ""10:00AM - 5:00PM"",
            ""sunday"": ""10:00AM - 5:00PM"",
            ""tuesday"": ""10:00AM - 5:00PM"",
            ""friday"": ""10:00AM - 5:00PM"",
            ""saturday"": ""10:00AM - 5:00PM""
          },
          ""name"": ""Old South Meeting House""
        },
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""11:00AM - 4:00PM"",
                ""monday"": ""11:00AM - 4:00PM"",
                ""thursday"": ""11:00AM - 4:00PM"",
                ""sunday"": ""11:00AM - 4:00PM"",
                ""tuesday"": ""11:00AM - 4:00PM"",
                ""friday"": ""11:00AM - 4:00PM"",
                ""saturday"": ""11:00AM - 4:00PM""
              },
              ""startDate"": ""2024-05-27"",
              ""name"": ""Memorial Day"",
              ""endDate"": ""2024-05-27""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""11:00AM - 4:00PM"",
                ""monday"": ""Closed"",
                ""thursday"": ""11:00AM - 4:00PM"",
                ""sunday"": ""11:00AM - 4:00PM"",
                ""tuesday"": ""11:00AM - 4:00PM"",
                ""friday"": ""11:00AM - 4:00PM"",
                ""saturday"": ""11:00AM - 4:00PM""
              },
              ""startDate"": ""2024-07-01"",
              ""name"": ""Summer"",
              ""endDate"": ""2024-09-04""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving Day"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Year's Day"",
              ""endDate"": ""2025-01-01""
            }
          ],
          ""description"": ""The Great Hall is operated as a historic site by the National Park Service in partnership with the City of Boston. Faneuil Hall is owned and managed by the City of Boston. The Great Hall is closed to public visitation when City-permitted events are scheduled.\n\nVisitors can find maps and other visiting materials in the Great Hall."",
          ""standardHours"": {
            ""wednesday"": ""11:00AM - 4:00PM"",
            ""monday"": ""Closed"",
            ""thursday"": ""11:00AM - 4:00PM"",
            ""sunday"": ""11:00AM - 4:00PM"",
            ""tuesday"": ""Closed"",
            ""friday"": ""11:00AM - 4:00PM"",
            ""saturday"": ""11:00AM - 4:00PM""
          },
          ""name"": ""The Great Hall of Faneuil Hall""
        },
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""10:00AM - 6:00PM"",
                ""monday"": ""Closed"",
                ""thursday"": ""10:00AM - 6:00PM"",
                ""sunday"": ""10:00AM - 6:00PM"",
                ""tuesday"": ""10:00AM - 6:00PM"",
                ""friday"": ""10:00AM - 6:00PM"",
                ""saturday"": ""10:00AM - 6:00PM""
              },
              ""startDate"": ""2024-03-15"",
              ""name"": ""Summer Hours"",
              ""endDate"": ""2024-10-15""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving Day"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Year's Day"",
              ""endDate"": ""2025-01-01""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-20"",
              ""name"": ""Martin Luther King Jr.'s Birthday"",
              ""endDate"": ""2025-01-20""
            }
          ],
          ""description"": ""USS CONSTITUTION is the oldest commissioned ship in the United States Navy. Naval officers and crew still serve aboard the ship. The Navy operates the ship as a historic site in cooperation with the National Park Service."",
          ""standardHours"": {
            ""wednesday"": ""10:00AM - 4:00PM"",
            ""monday"": ""Closed"",
            ""thursday"": ""10:00AM - 4:00PM"",
            ""sunday"": ""10:00AM - 4:00PM"",
            ""tuesday"": ""Closed"",
            ""friday"": ""10:00AM - 4:00PM"",
            ""saturday"": ""10:00AM - 4:00PM""
          },
          ""name"": ""USS Constitution""
        },
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""9:30AM - 5:00PM"",
                ""monday"": ""9:30AM - 5:00PM"",
                ""thursday"": ""9:30AM - 5:00PM"",
                ""sunday"": ""9:30AM - 5:00PM"",
                ""tuesday"": ""9:30AM - 5:00PM"",
                ""friday"": ""9:30AM - 5:00PM"",
                ""saturday"": ""9:30AM - 5:00PM""
              },
              ""startDate"": ""2024-05-01"",
              ""name"": ""Summer Hours"",
              ""endDate"": ""2024-10-31""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving Day"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""10:00AM - 2:00PM"",
                ""monday"": ""10:00AM - 2:00PM"",
                ""thursday"": ""10:00AM - 2:00PM"",
                ""sunday"": ""10:00AM - 2:00PM"",
                ""tuesday"": ""10:00AM - 2:00PM"",
                ""friday"": ""10:00AM - 2:00PM"",
                ""saturday"": ""10:00AM - 2:00PM""
              },
              ""startDate"": ""2024-12-24"",
              ""name"": ""Christmas Eve"",
              ""endDate"": ""2024-12-24""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Year's Day"",
              ""endDate"": ""2025-01-01""
            }
          ],
          ""description"": ""USS Constitution Museum collects, preserves, and interprets the stories of \""Old Ironsides.\"" The museum is a partner of Boston National Historical Park located in the Charlestown Navy Yard."",
          ""standardHours"": {
            ""wednesday"": ""10:00AM - 5:00PM"",
            ""monday"": ""10:00AM - 5:00PM"",
            ""thursday"": ""10:00AM - 5:00PM"",
            ""sunday"": ""10:00AM - 5:00PM"",
            ""tuesday"": ""10:00AM - 5:00PM"",
            ""friday"": ""10:00AM - 5:00PM"",
            ""saturday"": ""10:00AM - 5:00PM""
          },
          ""name"": ""USS Constitution Museum""
        },
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""10:00AM - 5:00PM"",
                ""monday"": ""10:00AM - 5:00PM"",
                ""thursday"": ""10:00AM - 5:00PM"",
                ""sunday"": ""10:00AM - 5:00PM"",
                ""tuesday"": ""10:00AM - 5:00PM"",
                ""friday"": ""10:00AM - 5:00PM"",
                ""saturday"": ""10:00AM - 5:00PM""
              },
              ""startDate"": ""2024-05-27"",
              ""name"": ""Memorial Day"",
              ""endDate"": ""2024-05-27""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""10:00AM - 5:30PM"",
                ""monday"": ""Closed"",
                ""thursday"": ""10:00AM - 5:30PM"",
                ""sunday"": ""10:00AM - 5:30PM"",
                ""tuesday"": ""10:00AM - 5:30PM"",
                ""friday"": ""10:00AM - 5:30PM"",
                ""saturday"": ""10:00AM - 5:30PM""
              },
              ""startDate"": ""2024-06-30"",
              ""name"": ""Summer"",
              ""endDate"": ""2024-11-11""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2023-11-12"",
              ""name"": ""Off-season"",
              ""endDate"": ""2024-05-25""
            }
          ],
          ""description"": ""USS CASSIN YOUNG is a Fletcher Class destroyer docked in the Charlestown Navy Yard. Park staff operate the ship seasonally. Weather conditions may alter hours without advanced notice."",
          ""standardHours"": {
            ""wednesday"": ""10:00AM - 4:30PM"",
            ""monday"": ""Closed"",
            ""thursday"": ""10:00AM - 4:30PM"",
            ""sunday"": ""10:00AM - 4:30PM"",
            ""tuesday"": ""Closed"",
            ""friday"": ""10:00AM - 4:30PM"",
            ""saturday"": ""10:00AM - 4:30PM""
          },
          ""name"": ""USS Cassin Young""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""02129"",
          ""city"": ""Charlestown"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""Boston National Historical Park"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": ""21 Second Ave""
        },
        {
          ""postalCode"": ""02129"",
          ""city"": ""Charlestown"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""Boston National Historical Park"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": ""21 Second Ave""
        }
      ],
      ""images"": [
        {
          ""credit"": ""Boston National Historical Park"",
          ""title"": ""Commandant's House"",
          ""altText"": ""Commandant's House in Spring"",
          ""caption"": ""Commandant's House is the oldest structure in the Charlestown Navy Yard."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/9698669F-1DD8-B71B-0BAF19BCD480270D.jpg""
        },
        {
          ""credit"": ""Boston National Historical Park"",
          ""title"": ""Paul Revere House Sign"",
          ""altText"": ""Paul Revere House Sign"",
          ""caption"": ""Paul Revere House is a proud partner of Boston National Historical Park"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/96A3AFDF-1DD8-B71B-0BECF3535FC1317B.jpg""
        },
        {
          ""credit"": ""Boston National Historical Park"",
          ""title"": ""Rainbow over Faneuil Hall"",
          ""altText"": ""Rainbow over Faneuil Hall"",
          ""caption"": ""Rare image of rainbow was captured over Faneuil Hall"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/96AD2B27-1DD8-B71B-0B2B3FC8BCA9B4BC.jpg""
        },
        {
          ""credit"": ""Boston National Historical Park"",
          ""title"": ""Colonial Town Meeting"",
          ""altText"": ""View of the Colonial Town Meeting program from the desk"",
          ""caption"": ""The Revolutionary Town Meeting program is one of the park's most popular."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/96C1990B-1DD8-B71B-0B8920EBAE88BC49.jpg""
        },
        {
          ""credit"": ""Boston National Historical Park"",
          ""title"": ""Navy Yard from the harbor"",
          ""altText"": ""View of the Navy Yard from the harbor showing the USS Constution, USS Cassin Young and Bunker Hill"",
          ""caption"": ""More than 200 years of Navy history and tradition can be found in the Charlestown Navy Yard."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/96D87235-1DD8-B71B-0B747DE0CE309802.jpg""
        }
      ],
      ""weatherInfo"": ""Temperatures range from warm, humid summer days to cold New England winter days. Wear comfortable sportswear in season, with comfortable walking shoes."",
      ""name"": ""Boston"",
      ""designation"": ""National Historical Park"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""DE0A8012-5324-4F5C-98DA-0EE6589FDFB3"",
      ""url"": ""https://www.nps.gov/caco/index.htm"",
      ""fullName"": ""Cape Cod National Seashore"",
      ""parkCode"": ""caco"",
      ""description"": ""The great Outer Beach described by Thoreau in the 1800s is protected within the national seashore. Forty miles of pristine sandy beach, marshes, ponds, and uplands support diverse species. Lighthouses, cultural landscapes, and wild cranberry bogs offer a glimpse of Cape Cod's past and continuing ways of life. Swimming beaches and walking and biking trails beckon today's visitors."",
      ""latitude"": ""41.92381465"",
      ""longitude"": ""-70.04319832"",
      ""latLong"": ""lat:41.92381465, long:-70.04319832"",
      ""activities"": [
        {
          ""id"": ""5F723BAD-7359-48FC-98FA-631592256E35"",
          ""name"": ""Auto and ATV""
        },
        {
          ""id"": ""DC668D29-297C-4D16-B6F8-89A67D9E19E3"",
          ""name"": ""Auto Off-Roading""
        },
        {
          ""id"": ""7CE6E935-F839-4FEC-A63E-052B1DEF39D2"",
          ""name"": ""Biking""
        },
        {
          ""id"": ""A59947B7-3376-49B4-AD02-C0423E08C5F7"",
          ""name"": ""Camping""
        },
        {
          ""id"": ""C5C5971C-E325-4CEB-8C81-EE49A881DF17"",
          ""name"": ""RV Camping""
        },
        {
          ""id"": ""AE42B46C-E4B7-4889-A122-08FE180371AE"",
          ""name"": ""Fishing""
        },
        {
          ""id"": ""25FB188F-5AAD-459A-9092-28A9801709FF"",
          ""name"": ""Freshwater Fishing""
        },
        {
          ""id"": ""17411C8D-5769-4D0F-ABD1-52ED03840C18"",
          ""name"": ""Saltwater Fishing""
        },
        {
          ""id"": ""3F3ABD16-2C52-4EAA-A1F6-4235DE5686F0"",
          ""name"": ""Golfing""
        },
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""3DE599E2-22ED-40BF-B383-EDA073563C1E"",
          ""name"": ""Bus/Shuttle Guided Tour""
        },
        {
          ""id"": ""BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA"",
          ""name"": ""Hiking""
        },
        {
          ""id"": ""45261C0A-00D8-4C27-A1F8-029F933A0D34"",
          ""name"": ""Front-Country Hiking""
        },
        {
          ""id"": ""8386EEAF-985F-4DE8-9037-CCF91975AC94"",
          ""name"": ""Hunting and Gathering""
        },
        {
          ""id"": ""25559F45-F162-4B8B-BEC2-B341034A2AF4"",
          ""name"": ""Hunting""
        },
        {
          ""id"": ""4D224BCA-C127-408B-AC75-A51563C42411"",
          ""name"": ""Paddling""
        },
        {
          ""id"": ""21DB3AFC-8AAC-4665-BC1F-7198C0685983"",
          ""name"": ""Canoeing""
        },
        {
          ""id"": ""F353A9ED-4A08-456E-8DEC-E61974D0FEB6"",
          ""name"": ""Kayaking""
        },
        {
          ""id"": ""B3EF12AF-D951-419E-BD3C-6B36CBCC1E16"",
          ""name"": ""Stand Up Paddleboarding""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""F9B1D433-6B86-4804-AED7-B50A519A3B7C"",
          ""name"": ""Skiing""
        },
        {
          ""id"": ""EAB1EBDE-5B72-493F-8F8F-0EE5B1724436"",
          ""name"": ""Cross-Country Skiing""
        },
        {
          ""id"": ""01D717BC-18BB-4FE4-95BA-6B13AD702038"",
          ""name"": ""Snowshoeing""
        },
        {
          ""id"": ""AE3C95F5-E05B-4A28-81DD-1C5FD4BE88E2"",
          ""name"": ""Surfing""
        },
        {
          ""id"": ""587BB2D3-EC35-41B2-B3F7-A39E2B088AEE"",
          ""name"": ""Swimming""
        },
        {
          ""id"": ""C2801992-F34D-4974-A0F2-80FF04309EE4"",
          ""name"": ""Saltwater Swimming""
        },
        {
          ""id"": ""0B685688-3405-4E2A-ABBA-E3069492EC50"",
          ""name"": ""Wildlife Watching""
        },
        {
          ""id"": ""5A2C91D1-50EC-4B24-8BED-A2E11A1892DF"",
          ""name"": ""Birdwatching""
        },
        {
          ""id"": ""0C0D142F-06B5-4BE1-8B44-491B90F93DEB"",
          ""name"": ""Park Film""
        },
        {
          ""id"": ""C8F98B28-3C10-41AE-AA99-092B3B398C43"",
          ""name"": ""Museum Exhibits""
        },
        {
          ""id"": ""24380E3F-AD9D-4E38-BF13-C8EEB21893E7"",
          ""name"": ""Shopping""
        },
        {
          ""id"": ""467DC8B8-0B7D-436D-A026-80A22358F615"",
          ""name"": ""Bookstore and Park Store""
        },
        {
          ""id"": ""43800AD1-D439-40F3-AAB3-9FB651FE45BB"",
          ""name"": ""Gift Shop and Souvenirs""
        }
      ],
      ""topics"": [
        {
          ""id"": ""00F3C3F9-2D67-4802-81AE-CCEA5D3BA370"",
          ""name"": ""Arts""
        },
        {
          ""id"": ""05B7868A-3F3C-433D-876E-A886C4BE7A12"",
          ""name"": ""Painting""
        },
        {
          ""id"": ""156AD9B6-B377-418C-BC9A-F6E682D4BAF7"",
          ""name"": ""Poetry and Literature""
        },
        {
          ""id"": ""7F12224B-217A-4B07-A4A2-636B1CE7F221"",
          ""name"": ""Colonization and Settlement""
        },
        {
          ""id"": ""4C9D4777-A9DA-47D1-A0B9-F4A3C98BC1B3"",
          ""name"": ""Maritime""
        },
        {
          ""id"": ""263BAC6E-4DEC-47E4-909D-DA8AD351E06E"",
          ""name"": ""Lighthouses""
        },
        {
          ""id"": ""A079385C-3E71-4E18-9E42-B046BC22EA95"",
          ""name"": ""Ships and Shipwrecks""
        },
        {
          ""id"": ""3B0D607D-9933-425A-BFA0-21529AC4734C"",
          ""name"": ""Military""
        },
        {
          ""id"": ""D164D82F-4031-4BCB-90A8-B388502CA308"",
          ""name"": ""US Coast Guard""
        },
        {
          ""id"": ""BEB7E470-13B2-4E00-84B2-0402D98DAF69"",
          ""name"": ""Monuments and Memorials""
        },
        {
          ""id"": ""A1BAF33E-EA84-4608-A888-4CEE9541F027"",
          ""name"": ""Native American Heritage""
        },
        {
          ""id"": ""D1CF31DE-AFED-412B-9425-DD1FD4CBB5C7"",
          ""name"": ""Science, Technology and Innovation""
        },
        {
          ""id"": ""27BF8807-54EA-4A3D-B073-AA7AA361CD7E"",
          ""name"": ""Wars and Conflicts""
        },
        {
          ""id"": ""A764E57D-9925-4855-8D66-C60357946FC3"",
          ""name"": ""Cold War""
        },
        {
          ""id"": ""0D00073E-18C3-46E5-8727-2F87B112DDC6"",
          ""name"": ""Animals""
        },
        {
          ""id"": ""957EF2BD-AC6C-4B7B-BD9A-87593ADC6691"",
          ""name"": ""Birds""
        },
        {
          ""id"": ""1608649A-E7D7-4529-BD83-074C90F9FB68"",
          ""name"": ""Fish""
        },
        {
          ""id"": ""393F60FB-80D6-46F7-B0FB-BBF3C90F59FD"",
          ""name"": ""Tortoises and Turtles""
        },
        {
          ""id"": ""4DC11D06-00F1-4A01-81D0-89CCCCE4FF50"",
          ""name"": ""Climate Change""
        },
        {
          ""id"": ""46FC5CBD-9AD5-48F1-B4DA-1357031B1D2E"",
          ""name"": ""Coasts, Islands and Atolls""
        },
        {
          ""id"": ""CDD8F34E-3BD4-425A-8264-4F0BA0DFBA38"",
          ""name"": ""Dunes""
        },
        {
          ""id"": ""F79C1242-80FF-40F0-A0C1-5FFCBA172EC0"",
          ""name"": ""Estuaries and Mangroves""
        },
        {
          ""id"": ""4BE01DC5-52E6-4F18-8C9A-B22D65965F6D"",
          ""name"": ""Groundwater""
        },
        {
          ""id"": ""F8C2FE93-DEB3-4B12-9A87-913E3E6B448D"",
          ""name"": ""Natural Sounds""
        },
        {
          ""id"": ""A7359FC4-DAD8-45F5-AF15-7FF62F816ED3"",
          ""name"": ""Night Sky""
        },
        {
          ""id"": ""0E6D8503-CB65-467F-BCD6-C6D9E28A4E0B"",
          ""name"": ""Oceans""
        },
        {
          ""id"": ""980D1693-65BF-4F29-8182-7BAC9796E605"",
          ""name"": ""Whales""
        },
        {
          ""id"": ""9C9FCBB6-360B-4743-8155-6F9341CBE01B"",
          ""name"": ""Scenic Views""
        },
        {
          ""id"": ""5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417"",
          ""name"": ""Trails""
        },
        {
          ""id"": ""1365C347-952C-475A-B755-731DD523C195"",
          ""name"": ""Wetlands""
        },
        {
          ""id"": ""FD0BA21A-5F69-4688-9D4B-856DA242DC78"",
          ""name"": ""Marshes""
        },
        {
          ""id"": ""86C6DC89-D311-44F8-A5BC-35F9FDC4AF1C"",
          ""name"": ""Swamps""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""508-255-3421"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""caco_information@nps.gov""
          }
        ]
      },
      ""entranceFees"": [
        {
          ""cost"": ""25.00"",
          ""description"": ""Pass is for one private, non-commercial vehicle � passenger cars, pickup trucks, RVs and vans."",
          ""title"": ""Entrance - Private Vehicle""
        },
        {
          ""cost"": ""20.00"",
          ""description"": ""Pass is for one motorcycle."",
          ""title"": ""Entrance - Motorcycle""
        },
        {
          ""cost"": ""15.00"",
          ""description"": ""Pass is for one person 16 years of age or older � entering on foot or by bicycle."",
          ""title"": ""Entrance - Per Person""
        }
      ],
      ""entrancePasses"": [
        {
          ""cost"": ""60.00"",
          ""description"": ""Passes are available at beach entrances during times when fees are normally collected. Entrance into the park with a pass may also require a driver's license or other form of picture identification. \n\nValid for the current season. Permits access to any of the six Cape Cod National Seashore beaches. The annual pass allows entrance for the pass holder and additional passengers in a single private non-commercial vehicle, or pass holder plus three adults when entering on foot or bicycle."",
          ""title"": ""Annual Entrance - Park""
        }
      ],
      ""fees"": [],
      ""directionsInfo"": ""The national seashore is located in eastern Massachusetts on Cape Cod and is accessed via Route 6. The park is 20 miles east of Hyannis, MA."",
      ""directionsUrl"": ""http://www.nps.gov/caco/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [],
          ""description"": ""Beaches, parking areas, and trails are open year-round between 6 AM and midnight."",
          ""standardHours"": {
            ""wednesday"": ""Opens at 6:00AM"",
            ""monday"": ""Opens at 6:00AM"",
            ""thursday"": ""Opens at 6:00AM"",
            ""sunday"": ""Opens at 6:00AM"",
            ""tuesday"": ""Opens at 6:00AM"",
            ""friday"": ""Opens at 6:00AM"",
            ""saturday"": ""Opens at 6:00AM""
          },
          ""name"": ""Cape Cod National Seashore""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""02642"",
          ""city"": ""Eastham"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""50 Nauset Road"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": """"
        },
        {
          ""postalCode"": ""02667"",
          ""city"": ""Wellfleet"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""99 Marconi Site Road"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": """"
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS image"",
          ""title"": ""Sunrise Waves"",
          ""altText"": ""A curling wave breaks against the backdrop of a pink sunrise."",
          ""caption"": ""Visiting the beach to watch the sunrise over the Atlantic Ocean is a beautiful experience."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C853027-1DD8-B71B-0B7E332E35FF7626.jpg""
        },
        {
          ""credit"": ""NPS photo"",
          ""title"": ""Sand Ripples"",
          ""altText"": ""Low tide exposes rippled ridges of sand and water."",
          ""caption"": ""You will never walk the same beach twice on Cape Cod; daily low and high tides expose and then cover the sand."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C8531C0-1DD8-B71B-0BE3CAF8B7CFED72.jpg""
        },
        {
          ""credit"": ""NPS photo"",
          ""title"": ""Exploring the Park by Water"",
          ""altText"": ""A red kayak floats on a pond facing a forest colored with red and orange leaves."",
          ""caption"": ""Exploring the park by water offers a different perspective."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C853320-1DD8-B71B-0B079D55D788EEAD.jpg""
        },
        {
          ""credit"": ""NPS photo"",
          ""title"": ""Birds and Beach"",
          ""altText"": ""A flock of birds flies along a beach with waves in the background."",
          ""caption"": ""The national seashore is known for its species diversity, including threatened and endangered shorebirds."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C85349E-1DD8-B71B-0B20658295A3DE59.jpg""
        },
        {
          ""credit"": ""NPS"",
          ""title"": ""Atlantic White Cedar Swamp Trail"",
          ""altText"": ""Boardwalk trail runs through a swamp surrounded by green ferns and tall trees."",
          ""caption"": ""This popular trail takes visitors through the rare habitat of an Atlantic White Cedar swamp."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/E7DA8038-AFE4-888A-1B3FC42E73D8A043.jpg""
        },
        {
          ""credit"": ""NPS"",
          ""title"": ""Sunrise Over the Atlantic"",
          ""altText"": ""A brilliant sun rises over the ocean reflecting light on the water's surface."",
          ""caption"": ""Cape Cod provides the opportunity to watch the sun rise out of the Atlantic Ocean and set into Cape Cod Bay."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/E7F7C4DF-C735-2DAD-A7A1595C204EB920.jpg""
        }
      ],
      ""weatherInfo"": ""Cape Cod's weather is generally moderated by its proximity to the ocean. Winter is typically cold with some snow. Spring is often rainy. Summer is usually warm and humid. Fall is generally dry and clear."",
      ""name"": ""Cape Cod"",
      ""designation"": ""National Seashore"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""CDC0FE7F-C249-466C-88B2-B81FC5279B91"",
      ""url"": ""https://www.nps.gov/frla/index.htm"",
      ""fullName"": ""Frederick Law Olmsted National Historic Site"",
      ""parkCode"": ""frla"",
      ""description"": ""Frederick Law Olmsted (1822-1903) is recognized as the founder of American landscape architecture and the nation's foremost parkmaker. Olmsted moved his home to suburban Boston in 1883 and established the world's first full-scale professional office for the practice of landscape design. During the next century, his sons and successors perpetuated Olmsted's design ideals, philosophy, and influence."",
      ""latitude"": ""42.32424266"",
      ""longitude"": ""-71.13202567"",
      ""latLong"": ""lat:42.32424266, long:-71.13202567"",
      ""activities"": [
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""A0631906-9672-4583-91DE-113B93DB6B6E"",
          ""name"": ""Self-Guided Tours - Walking""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""C8F98B28-3C10-41AE-AA99-092B3B398C43"",
          ""name"": ""Museum Exhibits""
        }
      ],
      ""topics"": [
        {
          ""id"": ""AF4F1CDF-E6C4-4886-BA91-8BC887DC2793"",
          ""name"": ""Landscape Design""
        },
        {
          ""id"": ""3CDB67A9-1EAC-408D-88EC-F26FA35E90AF"",
          ""name"": ""Schools and Education""
        },
        {
          ""id"": ""40C0866A-3890-41A4-84CA-5935DEE181AE"",
          ""name"": ""Social Movements""
        },
        {
          ""id"": ""4C0EBDE7-EB73-4252-84D9-0650974EC3E5"",
          ""name"": ""Conservation Movement""
        },
        {
          ""id"": ""27BF8807-54EA-4A3D-B073-AA7AA361CD7E"",
          ""name"": ""Wars and Conflicts""
        },
        {
          ""id"": ""A8E54356-20CD-490E-B34D-AC6A430E6F47"",
          ""name"": ""Civil War""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""6175661689"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""frla_interpretation@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""Site is located on the southwest corner of Warren and Dudley Streets in Brookline, south of Route 9, near the Brookline Reservoir. Site is 0.7 miles from the Brookline Hills MBTA stop on the Green Line, D Branch."",
      ""directionsUrl"": ""http://www.nps.gov/frla/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""friday"": ""9:30AM - 4:30PM"",
                ""saturday"": ""9:30AM - 4:30PM""
              },
              ""startDate"": ""2024-04-26"",
              ""name"": ""Spring Hours"",
              ""endDate"": ""2024-06-20""
            },
            {
              ""exceptionHours"": {
                ""friday"": ""9:30AM - 4:30PM"",
                ""saturday"": ""9:30AM - 4:30PM""
              },
              ""startDate"": ""2024-04-26"",
              ""name"": ""Spring Hours"",
              ""endDate"": ""2024-06-20""
            }
          ],
          ""description"": ""Frederick Law Olmsted National Historic Site is closed for the winter. Reserved tours may be accommodated based on staff availability. Please call 617-566-1689 ext 238 to arrange. \nFairsted's grounds are open daily from dawn to dusk. Self-guided landscape maps are available at the visitor center door."",
          ""standardHours"": {
            ""wednesday"": ""Closed"",
            ""monday"": ""Closed"",
            ""thursday"": ""Closed"",
            ""sunday"": ""Closed"",
            ""tuesday"": ""Closed"",
            ""friday"": ""Closed"",
            ""saturday"": ""Closed""
          },
          ""name"": ""General Hours""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""02445"",
          ""city"": ""Brookline"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""99 Warren Street"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": """"
        },
        {
          ""postalCode"": ""02445"",
          ""city"": ""Brookline"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""99 Warren Street"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": """"
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Frederick Law Olmsted National Historic Site"",
          ""altText"": ""Fairsted"",
          ""caption"": ""Fairsted, the home and office of landscape architect Frederick Law Olmsted. Frederick Law Olmsted National Historic Site."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C853BE9-1DD8-B71B-0B625B6B8B89F1A0.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Drafting Table"",
          ""altText"": ""Dark wood box with four shallow drawers on large wooden table with blueprint"",
          ""caption"": ""A box of colored pencils and a draftsmen's handbook sit on a table in the drafting room. These materials reflect the period during which Frederick Law Olmsted, Jr. was the senior partner in the Brookline, MA landscape architecture firm."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/95700E1B-E576-306D-59E3C9EB03E1F82F.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""The Hollow"",
          ""altText"": ""A shaded bench and plants in a sunken garden surrounded by bushes"",
          ""caption"": ""Landscape Architect Frederick Law Olmsted designed the Hollow on his Brookline, MA property to be a peaceful, picturesque sunken garden."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/957B0A62-B397-2547-EB145C134E3B9D99.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Plant Room"",
          ""altText"": ""Wicker chairs around table in room with rock covered wall with views outside"",
          ""caption"": ""Fairsted's Plant Room was the Olmsted family's favorite room in the house. With the rock walls and large windows to view the South Lawn, it was the perfect mix of interior and exterior."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/F62A9C77-9FB6-4235-F2763AB94A93491D.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""South Lawn"",
          ""altText"": ""Large flat grassy area with one tree in middle, other on sides, next to large house"",
          ""caption"": ""Fairsted's South Lawn served as an apple orchard for the previous owners, but the Olmsted's turned it into a sprawling open lawn where they hosted gatherings."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/F63AC0EF-A178-9C58-85C2F693D9A26848.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Vault"",
          ""altText"": ""Many pieces of paper wrapped around wooden rods stacked on top of each other"",
          ""caption"": ""The Vault at Fairsted houses over one million pieces of paper, dating from Frederick Law Olmsted Sr.'s time to 1979, when the firm closed."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/F64C534C-D5E0-CBC7-5C75F2B37B738D2C.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Drafting Department"",
          ""altText"": ""Large room with wooden tables and stools"",
          ""caption"": ""The Drafting Department housed the most office employees, with drafting being a crucial stage in a landscape design project."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/F65A8537-B59F-AA0C-C22A85A9C2ECCDE5.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Photo Records Room"",
          ""altText"": ""Room with wooded drawers along all the walls"",
          ""caption"": ""In nearly one hundred years of active practice, the Olmsted office would produce sixty thousand images, all stored in wooden boxes along the walls"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/F66B283D-0E82-08CB-12A7D7F643675E74.jpeg""
        }
      ],
      ""weatherInfo"": ""Summer: Warm temperatures, average high temperature around 80 degrees Fahrenheit, often with humidity. July and August bring the hottest temperatures. Fall: Cooler temperatures, mean temperatures between 45 and 65 degrees Fahrenheit, sometimes rainy. Peak fall foliage is in mid-October. Winter: Cold, with snow, average low temperature around 25 degrees Fahrenheit. Spring: Cold to cool temperatures, average mean temperatures between 40 and 60 degrees Fahrenheit."",
      ""name"": ""Frederick Law Olmsted"",
      ""designation"": ""National Historic Site"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""13E32BB8-D80B-45FA-ABF7-9C0CA5417ADC"",
      ""url"": ""https://www.nps.gov/jofi/index.htm"",
      ""fullName"": ""John Fitzgerald Kennedy National Historic Site"",
      ""parkCode"": ""jofi"",
      ""description"": ""As a boy, JFK�s parents never expected he would grow up to be president. Yet in his birthplace home he learned values that inspired a life in public service. His mother, Rose Kennedy, recreated her family�s first home to share her memories of those early years with visitors. We commemorate not only his early life, but the ideas and principles he left behind."",
      ""latitude"": ""42.34693694"",
      ""longitude"": ""-71.12323846"",
      ""latLong"": ""lat:42.34693694, long:-71.12323846"",
      ""activities"": [
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""0C0D142F-06B5-4BE1-8B44-491B90F93DEB"",
          ""name"": ""Park Film""
        },
        {
          ""id"": ""C8F98B28-3C10-41AE-AA99-092B3B398C43"",
          ""name"": ""Museum Exhibits""
        }
      ],
      ""topics"": [
        {
          ""id"": ""D10852A3-443C-4743-A5FA-6DD6D2A054B3"",
          ""name"": ""Birthplace""
        },
        {
          ""id"": ""2B428F59-9148-40C1-B38E-130589F2540E"",
          ""name"": ""Immigration""
        },
        {
          ""id"": ""BEB7E470-13B2-4E00-84B2-0402D98DAF69"",
          ""name"": ""Monuments and Memorials""
        },
        {
          ""id"": ""F669BC40-BDC4-41C0-9ACE-B2CD25373045"",
          ""name"": ""Presidents""
        },
        {
          ""id"": ""846E5C56-E5AC-489C-B3BF-11F4C73F12C2"",
          ""name"": ""Urban America""
        },
        {
          ""id"": ""7DA81DAB-5045-4953-9C20-36590AD9FA95"",
          ""name"": ""Women's History""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""6175667937"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          },
          {
            ""phoneNumber"": ""6177309884"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Fax""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""jason_atsales@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""By Subway: Take Green line (\""C\"" -Cleveland Circle) trolley to Coolidge Corner stop. Walk four blocks north on Harvard Street, turn right on Beals Street and continue to number 83. By Car: From Exit 18 (I-90 E) or Exit 20 (1-90 W) follow the Allston/Brighton exit ramp, merge onto Cambridge Street and go one mile. At the fourth light, turn left on Harvard Street and proceed about one mile. Turn left on Beals Street and go to number 83. Limited Street Parking available."",
      ""directionsUrl"": ""http://www.nps.gov/jofi/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2023-11-19"",
              ""name"": ""Winter Closure"",
              ""endDate"": ""2024-05-27""
            }
          ],
          ""description"": ""The historic house is open by guided tour. Self-guided tours are available during scheduled open house hours. See the park website for tour times and options."",
          ""standardHours"": {
            ""wednesday"": ""Closed"",
            ""monday"": ""Closed"",
            ""thursday"": ""9:30AM - 5:00PM"",
            ""sunday"": ""9:30AM - 5:00PM"",
            ""tuesday"": ""Closed"",
            ""friday"": ""9:30AM - 5:00PM"",
            ""saturday"": ""9:30AM - 5:00PM""
          },
          ""name"": ""Summer Open Season""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""02446"",
          ""city"": ""Brookline"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""83 Beals Street"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": """"
        },
        {
          ""postalCode"": ""02446"",
          ""city"": ""Brookline"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""83 Beals Street"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": """"
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""John Fitzgerald Kennedy National Historic Site"",
          ""altText"": ""John Fitzgerald Kennedy National Historic Site"",
          ""caption"": ""Photograph of the birthplace of John F. Kennedy on Beals st. in Brookline, MA"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C820F63-1DD8-B71B-0BA806C2D92161BF.jpg""
        },
        {
          ""credit"": ""NPS / Robert Perron"",
          ""title"": ""Nursery"",
          ""altText"": ""Room with white wicker furniture, including bassinet and rocking chair. Long white baby dress hangs."",
          ""caption"": ""The Kennedy christening gown on a stand next to the bassinet in which all the Kennedy children slept, at the John F. Kennedy National Historic Site."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/4AC1549C-BD5C-B852-7B4D8CBCD5B2AF86.jpg""
        },
        {
          ""credit"": ""NPS / Robert Perron"",
          ""title"": ""Kennedy Dining Room"",
          ""altText"": ""Dining room with oval dining table with six place settings of silver and fine china."",
          ""caption"": ""The dining table is set with the fine china and silver that Rose Kennedy received as a wedding present."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/4AA5B49F-ECA2-C60D-69B4B0B6D59BAA5D.jpg""
        }
      ],
      ""weatherInfo"": ""Typical New England Weather: Warm, humid summers and cold winters. Any available outdoor programs take place rain or shine."",
      ""name"": ""John Fitzgerald Kennedy"",
      ""designation"": ""National Historic Site"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""CE9470A1-A8D7-49DE-A555-1A32FBBAB0FF"",
      ""url"": ""https://www.nps.gov/long/index.htm"",
      ""fullName"": ""Longfellow House Washington's Headquarters National Historic Site"",
      ""parkCode"": ""long"",
      ""description"": ""Longfellow House-Washington's Headquarters National Historic Site preserves a remarkable Georgian house whose occupants shaped our nation. It was a site of colonial enslavement and community activism, George Washington�s first long-term headquarters of the American Revolution, and the place where Henry Wadsworth Longfellow wrote his canon of 19th-century American literature."",
      ""latitude"": ""42.37698854"",
      ""longitude"": ""-71.12636956"",
      ""latLong"": ""lat:42.37698854, long:-71.12636956"",
      ""activities"": [
        {
          ""id"": ""09DF0950-D319-4557-A57E-04CD2F63FF42"",
          ""name"": ""Arts and Culture""
        },
        {
          ""id"": ""C0FFC3D5-0E74-4B6F-B69D-6F95B78906CE"",
          ""name"": ""Live Music""
        },
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""42FD78B9-2B90-4AA9-BC43-F10E9FEA8B5A"",
          ""name"": ""Hands-On""
        },
        {
          ""id"": ""19A59EFB-DF4B-4049-9EE1-A784CAC9C70C"",
          ""name"": ""Arts and Crafts""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""C8F98B28-3C10-41AE-AA99-092B3B398C43"",
          ""name"": ""Museum Exhibits""
        }
      ],
      ""topics"": [
        {
          ""id"": ""69693007-2DF2-4EDE-BB3B-A25EBA72BDF5"",
          ""name"": ""Architecture and Building""
        },
        {
          ""id"": ""28AEAE85-9DDA-45B6-981B-1CFCDCC61E14"",
          ""name"": ""African American Heritage""
        },
        {
          ""id"": ""F3883A66-A7CB-461B-868E-1B5932224B25"",
          ""name"": ""American Revolution""
        },
        {
          ""id"": ""00F3C3F9-2D67-4802-81AE-CCEA5D3BA370"",
          ""name"": ""Arts""
        },
        {
          ""id"": ""05B7868A-3F3C-433D-876E-A886C4BE7A12"",
          ""name"": ""Painting""
        },
        {
          ""id"": ""9BD60DC0-C82B-42BA-A170-456B7423429D"",
          ""name"": ""Photography""
        },
        {
          ""id"": ""156AD9B6-B377-418C-BC9A-F6E682D4BAF7"",
          ""name"": ""Poetry and Literature""
        },
        {
          ""id"": ""0DE2D6B3-46DE-44B1-BB5F-E9E8874630D5"",
          ""name"": ""Sculpture""
        },
        {
          ""id"": ""1170EEB6-5070-4760-8E7D-FF1A98272FAD"",
          ""name"": ""Commerce""
        },
        {
          ""id"": ""A010EADF-78B8-4526-B0A4-70B0E0B3470E"",
          ""name"": ""Trade""
        },
        {
          ""id"": ""D9FC6D14-F8C7-4EBA-86EA-DFD99B6BB4F5"",
          ""name"": ""Enslavement""
        },
        {
          ""id"": ""0B575E33-B68F-4F3D-998E-B03284606CF3"",
          ""name"": ""Industry""
        },
        {
          ""id"": ""14FA9FF3-7D86-4406-9A6D-BE9032A1C578"",
          ""name"": ""Laborer and Worker""
        },
        {
          ""id"": ""E0AB480F-3A94-4DC1-8B21-9555F2C59B32"",
          ""name"": ""LGBTQ American Heritage""
        },
        {
          ""id"": ""AF4F1CDF-E6C4-4886-BA91-8BC887DC2793"",
          ""name"": ""Landscape Design""
        },
        {
          ""id"": ""3B0D607D-9933-425A-BFA0-21529AC4734C"",
          ""name"": ""Military""
        },
        {
          ""id"": ""E411F474-A530-4804-9D23-1D94C78B41E4"",
          ""name"": ""Infantry and Militia""
        },
        {
          ""id"": ""A1BAF33E-EA84-4608-A888-4CEE9541F027"",
          ""name"": ""Native American Heritage""
        },
        {
          ""id"": ""F669BC40-BDC4-41C0-9ACE-B2CD25373045"",
          ""name"": ""Presidents""
        },
        {
          ""id"": ""518B32FB-339D-4C52-B2C2-04BF406AA4B0"",
          ""name"": ""Religion and Spirituality""
        },
        {
          ""id"": ""3CDB67A9-1EAC-408D-88EC-F26FA35E90AF"",
          ""name"": ""Schools and Education""
        },
        {
          ""id"": ""40C0866A-3890-41A4-84CA-5935DEE181AE"",
          ""name"": ""Social Movements""
        },
        {
          ""id"": ""5CCB14BC-2AC4-45CE-B786-54A065DA1B60"",
          ""name"": ""Abolition Movement""
        },
        {
          ""id"": ""27BF8807-54EA-4A3D-B073-AA7AA361CD7E"",
          ""name"": ""Wars and Conflicts""
        },
        {
          ""id"": ""3D2EE3E9-7344-416C-A412-C2C7CDCDE684"",
          ""name"": ""Colonial/European Contact Conflicts""
        },
        {
          ""id"": ""480D5BD7-D43B-44BB-AD82-1751CB859054"",
          ""name"": ""French and Indian War""
        },
        {
          ""id"": ""990E22A2-20D8-4CC2-8E6C-D2DF165BCDA5"",
          ""name"": ""American Revolutionary War""
        },
        {
          ""id"": ""A8E54356-20CD-490E-B34D-AC6A430E6F47"",
          ""name"": ""Civil War""
        },
        {
          ""id"": ""A28F8700-794E-4BA3-A8D7-7D75D53A4B17"",
          ""name"": ""Spanish-American War""
        },
        {
          ""id"": ""4EC51024-F0D9-479D-AF3F-344CC0153D2E"",
          ""name"": ""World War I""
        },
        {
          ""id"": ""A764E57D-9925-4855-8D66-C60357946FC3"",
          ""name"": ""Cold War""
        },
        {
          ""id"": ""7DA81DAB-5045-4953-9C20-36590AD9FA95"",
          ""name"": ""Women's History""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""(617) 876-4491"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""long_info@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""Longfellow House-Washington's Headquarters NHS is located in a residential section of Cambridge, MA. There is very little public parking in the area and onsite parking is limited to vehicles with handicapped parking permits. However, the site is a short walk from Harvard Square, where there are paid parking lots and a station for the MBTA Red Line and numerous bus routes. The use of public transportation to the site is highly recommended. Follow the link for detailed instructions."",
      ""directionsUrl"": ""http://www.nps.gov/long/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2023-11-01"",
              ""name"": ""Closed November 1, 2023 through May 23, 2024"",
              ""endDate"": ""2024-05-23""
            }
          ],
          ""description"": ""The site is open for tours May 24-October 28, 2024. The grounds and garden are open year-round daily, dawn-dusk."",
          ""standardHours"": {
            ""wednesday"": ""Closed"",
            ""monday"": ""9:30AM - 5:00PM"",
            ""thursday"": ""Closed"",
            ""sunday"": ""9:30AM - 5:00PM"",
            ""tuesday"": ""Closed"",
            ""friday"": ""9:30AM - 5:00PM"",
            ""saturday"": ""9:30AM - 5:00PM""
          },
          ""name"": ""Operating Hours""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""02138"",
          ""city"": ""Cambridge"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""105 Brattle Street"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": """"
        },
        {
          ""postalCode"": ""02138"",
          ""city"": ""Cambridge"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""105 Brattle Street"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": """"
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo / James P. Jones | Photography RI"",
          ""title"": ""Front Facade"",
          ""altText"": ""Yellow three-story mansion with symmetrical facade. Steps and large lawn in foreground. Framed by br"",
          ""caption"": ""Elm trees frame the front facade of the Vassall-Craigie-Longfellow House."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3F81541A-CC01-7548-8F7723937ECD58D8.jpg""
        },
        {
          ""credit"": ""NPS Photo/ Garrett Cloer"",
          ""title"": ""Fun for All Ages"",
          ""altText"": ""children interacting with puppet"",
          ""caption"": ""Special events create fun for all ages."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3993EE60-1DD8-B71B-0BFAC5A00BF0CF75.jpg""
        },
        {
          ""credit"": ""NPS Photo / James P. Jones | Photography RI"",
          ""title"": ""Henry Wadsworth Longfellow's Study"",
          ""altText"": ""View of a study with a round center table cluttered with books and writing implements."",
          ""caption"": ""The Longfellow study table is cluttered with books and writing implements. The black \""Chestnut Tree Chair\"" was a gift to Henry Longfellow in honor of his poem, \""The Village Blacksmith.\"""",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/5404730D-A660-4FEA-F70E5FD256DCC152.jpg""
        },
        {
          ""credit"": ""NPS Photo / James P. Jones | Photography RI"",
          ""title"": ""Front Hall"",
          ""altText"": ""A staircase with white balusters and green carpet. A bust of Washington sits at the turn of stairs."",
          ""caption"": ""The Longfellows' iconic front entry features a bust of Washington at the turn of the stairs"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/543D3934-09B5-AB26-094B37429B74A1CD.jpg""
        },
        {
          ""credit"": ""NPS Photo/ Garrett Cloer"",
          ""title"": ""Longfellow House-Washington's Headquarters National Historic Site"",
          ""altText"": ""mansion highlighted by the changing colors of fall"",
          ""caption"": ""Thousands tour the historic headquarters of George Washington and home of Henry Longfellow each summer."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/39575623-1DD8-B71B-0BA5AE9AB6BEB650.jpg""
        },
        {
          ""credit"": ""NPS Photo/ Garrett Cloer"",
          ""title"": ""Longfellow Family Garden"",
          ""altText"": ""garden back dropped by house"",
          ""caption"": ""The Longfellow Family Garden provides a peaceful getaway in the heart of Cambridge."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/397111E0-1DD8-B71B-0BA6161F336D01D5.jpg""
        },
        {
          ""credit"": ""NPS Photo/Garrett Cloer"",
          ""title"": ""Summer Festival Concert"",
          ""altText"": ""large crowd on the east lawn listening to singers perfom"",
          ""caption"": ""Each year is highlighted by the Summer Festival on the house's east lawn."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3980F568-1DD8-B71B-0B2C8891C1B5FB5F.jpg""
        },
        {
          ""credit"": ""NPS Photo/ Garrett Cloer"",
          ""title"": ""Winter at Longfellow House-Washington's Headquarters National Historic Site"",
          ""altText"": ""house covered with new fallen snow"",
          ""caption"": ""New fallen snow blankets the historic mansion."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/39308375-1DD8-B71B-0B9460827B3221DB.jpg""
        },
        {
          ""credit"": ""NPS Photo/ Garrett Cloer"",
          ""title"": ""Longfellow Family Garden"",
          ""altText"": ""pink flower in garden"",
          ""caption"": ""Vibrant colors abound throughout the year in the Longfellow Family Garden."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/39BDB843-1DD8-B71B-0B90045654B4D283.jpg""
        }
      ],
      ""weatherInfo"": ""New England weather is highly variable. Temperatures in the winter can be very cold with high snowfall. Fall and spring are generally pleasant. Summer temperatures are generally mild, with periods of heat and humidity. However, the house is air conditioned and heated for collection care and the comfort of the visitor."",
      ""name"": ""Longfellow House Washington's Headquarters"",
      ""designation"": ""National Historic Site"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""FA6450A4-D2F1-4B35-9817-EA01918597A6"",
      ""url"": ""https://www.nps.gov/lowe/index.htm"",
      ""fullName"": ""Lowell National Historical Park"",
      ""parkCode"": ""lowe"",
      ""description"": ""Lowell�s water-powered textile mills catapulted the nation � including immigrant families and early female factory workers � into an uncertain new industrial era. Nearly 200 years later, the changes that began here still reverberate in our shifting global economy. Explore Lowell, a living testament to the dynamic human story of the industrial revolution."",
      ""latitude"": ""42.6455371"",
      ""longitude"": ""-71.31588673"",
      ""latLong"": ""lat:42.6455371, long:-71.31588673"",
      ""activities"": [
        {
          ""id"": ""09DF0950-D319-4557-A57E-04CD2F63FF42"",
          ""name"": ""Arts and Culture""
        },
        {
          ""id"": ""C59E231D-55FC-4B37-BC5B-FF76383951B5"",
          ""name"": ""Craft Demonstrations""
        },
        {
          ""id"": ""FAED7F97-3474-4C21-AB42-FB0768A2F826"",
          ""name"": ""Cultural Demonstrations""
        },
        {
          ""id"": ""C0FFC3D5-0E74-4B6F-B69D-6F95B78906CE"",
          ""name"": ""Live Music""
        },
        {
          ""id"": ""071BA73C-1D3C-46D4-A53C-00D5602F7F0E"",
          ""name"": ""Boating""
        },
        {
          ""id"": ""A510F02B-8938-4679-A4F9-76580BCAE9C7"",
          ""name"": ""Boat Tour""
        },
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""A0631906-9672-4583-91DE-113B93DB6B6E"",
          ""name"": ""Self-Guided Tours - Walking""
        },
        {
          ""id"": ""5A241412-0CFB-497A-9B5F-0AB8C03CDE72"",
          ""name"": ""Boat Tour""
        },
        {
          ""id"": ""42FD78B9-2B90-4AA9-BC43-F10E9FEA8B5A"",
          ""name"": ""Hands-On""
        },
        {
          ""id"": ""19A59EFB-DF4B-4049-9EE1-A784CAC9C70C"",
          ""name"": ""Arts and Crafts""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""0C0D142F-06B5-4BE1-8B44-491B90F93DEB"",
          ""name"": ""Park Film""
        },
        {
          ""id"": ""C8F98B28-3C10-41AE-AA99-092B3B398C43"",
          ""name"": ""Museum Exhibits""
        },
        {
          ""id"": ""24380E3F-AD9D-4E38-BF13-C8EEB21893E7"",
          ""name"": ""Shopping""
        },
        {
          ""id"": ""467DC8B8-0B7D-436D-A026-80A22358F615"",
          ""name"": ""Bookstore and Park Store""
        },
        {
          ""id"": ""43800AD1-D439-40F3-AAB3-9FB651FE45BB"",
          ""name"": ""Gift Shop and Souvenirs""
        }
      ],
      ""topics"": [
        {
          ""id"": ""DAAD7F5E-9112-45F2-9A27-DA51B639F27E"",
          ""name"": ""Dams""
        },
        {
          ""id"": ""FE005582-12C5-472C-8229-3CB004DB050E"",
          ""name"": ""Engineering""
        },
        {
          ""id"": ""0B575E33-B68F-4F3D-998E-B03284606CF3"",
          ""name"": ""Industry""
        },
        {
          ""id"": ""AAF8795A-231B-4DA4-B564-AA51C95E72BD"",
          ""name"": ""Factories""
        },
        {
          ""id"": ""BD81BF37-14B1-408A-903F-2BF52C8C7927"",
          ""name"": ""Mills""
        },
        {
          ""id"": ""2B428F59-9148-40C1-B38E-130589F2540E"",
          ""name"": ""Immigration""
        },
        {
          ""id"": ""14FA9FF3-7D86-4406-9A6D-BE9032A1C578"",
          ""name"": ""Laborer and Worker""
        },
        {
          ""id"": ""1F95D138-CE10-40B5-95D0-B5BE4133B3A1"",
          ""name"": ""Migrant Workers""
        },
        {
          ""id"": ""E1C7ED3C-C804-4D96-B565-B4A13BEBB00E"",
          ""name"": ""Labor Movement""
        },
        {
          ""id"": ""D1CF31DE-AFED-412B-9425-DD1FD4CBB5C7"",
          ""name"": ""Science, Technology and Innovation""
        },
        {
          ""id"": ""9749E14B-ED9A-4E86-BAEA-CAC7B718F266"",
          ""name"": ""Canals""
        },
        {
          ""id"": ""D91B6F1A-FED8-490D-B181-9940474CD67C"",
          ""name"": ""Floods""
        },
        {
          ""id"": ""846E5C56-E5AC-489C-B3BF-11F4C73F12C2"",
          ""name"": ""Urban America""
        },
        {
          ""id"": ""7DA81DAB-5045-4953-9C20-36590AD9FA95"",
          ""name"": ""Women's History""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""9789705000"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          },
          {
            ""phoneNumber"": ""9789705002"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""TTY""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""lowe_public_information@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""From Interstate Route 495 take Exit 89C on to the Lowell Connector. From Route 3 take Exit 80A if traveling southbound, Exit 80B if traveling northbound. � Take the Lowell Connector to Exit 5B (Thorndike Street) � Continue right on to Thorndike Street, which becomes Dutton Street � At the third traffic light continue straight under the overpass � At the next light turn right. Free parking is available at the City garage. Follow signs and walk through the mill courtyard to reach the Visitor Center"",
      ""directionsUrl"": ""http://www.nps.gov/lowe/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""12:00PM - 5:00PM"",
                ""monday"": ""12:00PM - 5:00PM"",
                ""thursday"": ""12:00PM - 5:00PM"",
                ""sunday"": ""10:00AM - 5:00PM"",
                ""tuesday"": ""12:00PM - 5:00PM"",
                ""friday"": ""12:00PM - 5:00PM"",
                ""saturday"": ""10:00AM - 5:00PM""
              },
              ""startDate"": ""2024-11-27"",
              ""name"": ""Winter Hours"",
              ""endDate"": ""2025-04-27""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-24"",
              ""name"": ""Christmas Eve and Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Years Day"",
              ""endDate"": ""2025-01-01""
            }
          ],
          ""description"": ""The Boott Cotton Mills Museum (115 John Street) and the Visitor Center (246 Market Street) are open Daily 10 a.m. - 5 p.m.\n\nThe Mogan Cultural Center, which houses the 'Into an 1840s Boarding House' exhibit and the 'One City, Many Cultures' exhibit, (40 French Street) is open Daily 11 a.m. - 4:30 p.m."",
          ""standardHours"": {
            ""wednesday"": ""10:00AM - 5:00PM"",
            ""monday"": ""10:00AM - 5:00PM"",
            ""thursday"": ""10:00AM - 5:00PM"",
            ""sunday"": ""10:00AM - 5:00PM"",
            ""tuesday"": ""10:00AM - 5:00PM"",
            ""friday"": ""10:00AM - 5:00PM"",
            ""saturday"": ""10:00AM - 5:00PM""
          },
          ""name"": ""Lowell National Historical Park""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""01852"",
          ""city"": ""Lowell"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""246 Market Street"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": """"
        },
        {
          ""postalCode"": ""01852"",
          ""city"": ""Lowell"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""67 Kirk Street"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": """"
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Boott Cotton Mills"",
          ""altText"": ""5 story brick factories with a clocktower surrounding a central courtyard"",
          ""caption"": ""The Boott Cotton Mills is one of the best, most-intact complexes of cotton mills from Lowell's heyday in the 19th century."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/540E0A41-958B-903A-9034B50FD25C4D69.jpg""
        },
        {
          ""credit"": ""NPS Photo/David Byers"",
          ""title"": ""Tsongas Center Programs"",
          ""altText"": ""Two students weaving on the looms at the education center."",
          ""caption"": ""The Tsongas Industrial History Center, a partnership of Lowell National Historical Park and UMass Lowell's Graduate School of Education, offers hands-on interactive education workshops for more than 50,000 students each year."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7D2D96-1DD8-B71B-0BB7225181B9E6B6.jpg""
        },
        {
          ""credit"": ""NPS Photo/James Higgins"",
          ""title"": ""Lowell NHP Trolley"",
          ""altText"": ""Streetcar guided through Lowell by motormen with lots of passengers"",
          ""caption"": ""Lowell National Historical Park operates reproduction vintage streetcars throughout the park and downtown Lowell. Climb onboard for a ride or a ranger-guided tour."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7D2A20-1DD8-B71B-0BCE6F45096D30F1.jpg""
        },
        {
          ""credit"": ""NPS Photo/Andy Pearson"",
          ""title"": ""Boott Mills Weave Room"",
          ""altText"": ""Two young visitors look over the rail at a room full of working looms"",
          ""caption"": ""The working weave room at the Boott Cotton Mills Museum surrounds you with the sights and sounds of a turn-of-the-century working cotton textile factory."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7D2BF1-1DD8-B71B-0BE36B49DC090AE1.jpg""
        },
        {
          ""credit"": ""NPS Photo/ Andy Pearson"",
          ""title"": ""Lowell Folk Festival"",
          ""altText"": ""Street scene with lots of tents and crowds listening to Folk Festival music at Boardinghouse Park."",
          ""caption"": ""The Lowell Folk Festival, Lowell's signature annual event, brings traditional folk performers to 5 stages throughout the city and a huge variety of traditional ethnic foods from all around the world."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7D31BD-1DD8-B71B-0B6E59CD838FDB56.jpg""
        }
      ],
      ""weatherInfo"": ""Summer: Throughout the summer, temperatures range from the mid 60s to mid 90s during the day, with rain and thunderstorms more common in the months of July and August. Boats and trolleys operate rain or shine and are only cancelled in cases of extreme weather or the presence of thunder and lightning. Winter: Winters are typically cold with temperatures in the mid 30s and 40s (with occasional single digit temperatures) and snow storms with a few inches accumulation occur frequently throughout the season."",
      ""name"": ""Lowell"",
      ""designation"": ""National Historical Park"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""3AB31FA9-E174-4A03-952D-397944D3A3C8"",
      ""url"": ""https://www.nps.gov/mima/index.htm"",
      ""fullName"": ""Minute Man National Historical Park"",
      ""parkCode"": ""mima"",
      ""description"": ""At Minute Man National Historical Park the opening battle of the Revolution is brought to life as visitors explore the battlefields and structures associated with April 19, 1775, and witness the American revolutionary spirit through the writings of the Concord authors."",
      ""latitude"": ""42.4562778"",
      ""longitude"": ""-71.30738884"",
      ""latLong"": ""lat:42.4562778, long:-71.30738884"",
      ""activities"": [
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA"",
          ""name"": ""Hiking""
        },
        {
          ""id"": ""45261C0A-00D8-4C27-A1F8-029F933A0D34"",
          ""name"": ""Front-Country Hiking""
        },
        {
          ""id"": ""B204DE60-5A24-43DD-8902-C81625A09A74"",
          ""name"": ""Living History""
        },
        {
          ""id"": ""237A1662-6018-4115-ABD1-B8CCF827E703"",
          ""name"": ""Historic Weapons Demonstration""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""24380E3F-AD9D-4E38-BF13-C8EEB21893E7"",
          ""name"": ""Shopping""
        },
        {
          ""id"": ""467DC8B8-0B7D-436D-A026-80A22358F615"",
          ""name"": ""Bookstore and Park Store""
        }
      ],
      ""topics"": [
        {
          ""id"": ""69693007-2DF2-4EDE-BB3B-A25EBA72BDF5"",
          ""name"": ""Architecture and Building""
        },
        {
          ""id"": ""28AEAE85-9DDA-45B6-981B-1CFCDCC61E14"",
          ""name"": ""African American Heritage""
        },
        {
          ""id"": ""F3883A66-A7CB-461B-868E-1B5932224B25"",
          ""name"": ""American Revolution""
        },
        {
          ""id"": ""00F3C3F9-2D67-4802-81AE-CCEA5D3BA370"",
          ""name"": ""Arts""
        },
        {
          ""id"": ""156AD9B6-B377-418C-BC9A-F6E682D4BAF7"",
          ""name"": ""Poetry and Literature""
        },
        {
          ""id"": ""0DE2D6B3-46DE-44B1-BB5F-E9E8874630D5"",
          ""name"": ""Sculpture""
        },
        {
          ""id"": ""D9FC6D14-F8C7-4EBA-86EA-DFD99B6BB4F5"",
          ""name"": ""Enslavement""
        },
        {
          ""id"": ""3B0D607D-9933-425A-BFA0-21529AC4734C"",
          ""name"": ""Military""
        },
        {
          ""id"": ""E411F474-A530-4804-9D23-1D94C78B41E4"",
          ""name"": ""Infantry and Militia""
        },
        {
          ""id"": ""6A3658B4-FB6E-4E23-A63A-9AEF11988831"",
          ""name"": ""Battlefields""
        },
        {
          ""id"": ""40C0866A-3890-41A4-84CA-5935DEE181AE"",
          ""name"": ""Social Movements""
        },
        {
          ""id"": ""5CCB14BC-2AC4-45CE-B786-54A065DA1B60"",
          ""name"": ""Abolition Movement""
        },
        {
          ""id"": ""27BF8807-54EA-4A3D-B073-AA7AA361CD7E"",
          ""name"": ""Wars and Conflicts""
        },
        {
          ""id"": ""990E22A2-20D8-4CC2-8E6C-D2DF165BCDA5"",
          ""name"": ""American Revolutionary War""
        },
        {
          ""id"": ""7DA81DAB-5045-4953-9C20-36590AD9FA95"",
          ""name"": ""Women's History""
        },
        {
          ""id"": ""0D00073E-18C3-46E5-8727-2F87B112DDC6"",
          ""name"": ""Animals""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""9783696993"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""mima_info@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""Minute Man National Historical Park is located just off of I-95, exit 46B (old exit 30B), Rt 2A west, starting in Lexington, then west through Lincoln and into Concord."",
      ""directionsUrl"": ""https://www.nps.gov/mima/planyourvisit/directions-transportation.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [],
          ""description"": ""The grounds of Minute Man National Historical Park are open daily, sunrise to sunset. Parking lot gates close at sunset."",
          ""standardHours"": {
            ""wednesday"": ""Sunrise to Sunset"",
            ""monday"": ""Sunrise to Sunset"",
            ""thursday"": ""Sunrise to Sunset"",
            ""sunday"": ""Sunrise to Sunset"",
            ""tuesday"": ""Sunrise to Sunset"",
            ""friday"": ""Sunrise to Sunset"",
            ""saturday"": ""Sunrise to Sunset""
          },
          ""name"": ""Minute Man National Historical Park""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""01773"",
          ""city"": ""Lincoln"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""Minute Man Visitor Center"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": ""210 North Great Road""
        },
        {
          ""postalCode"": ""01742"",
          ""city"": ""Concord"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""North Bridge / Park Headquarters"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": ""174 Liberty St.""
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo/P. Lupsiewicz"",
          ""title"": ""Concord Minute Man"",
          ""altText"": ""By daniel Chester French"",
          ""caption"": ""The embattled farmer stands guard over North Bridge, Concord."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C8093FE-1DD8-B71B-0B136DB5E8378F8C.jpg""
        },
        {
          ""credit"": ""NPS Photo/P. Lupsiewicz"",
          ""title"": ""Captain William Smith House"",
          ""altText"": ""Located on Battle Road, the Smith House was home of Captain John Smith of the Lincoln Militia."",
          ""caption"": ""The Smith House is a witness to the days events of April 19, 1775."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C809778-1DD8-B71B-0B66B50F57E39E75.jpg""
        },
        {
          ""credit"": ""NPS Photo/P. Lupsiewicz"",
          ""title"": ""Fifler"",
          ""altText"": ""a women in colonial clothes plays the fife."",
          ""caption"": ""A fifer at the annual William Diamond Muster at the Minute Man Visitor Center"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C809A69-1DD8-B71B-0B1B0CF6B60B12AE.jpg""
        },
        {
          ""credit"": ""NPS photo"",
          ""title"": ""North Bridge"",
          ""altText"": ""A wooden bridge spans the Concord river as people walk and canoe paddlers gluide under the bridge"",
          ""caption"": ""North Bridge, Concord Massachusetts"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C809BBC-1DD8-B71B-0B28100B8F89B083.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Living History!"",
          ""altText"": ""A company of armed minute men stand in formation along a dirt road with the officer out in front."",
          ""caption"": ""History comes alive!"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/1D880007-9D4B-60FA-6E450A3F95ABB033.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""The Battle Road Trail"",
          ""altText"": ""A narrow dirt track runs through green fields shaded by large trees."",
          ""caption"": ""Walk in the footsteps of history"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/1D95937F-B2CB-371C-020E2C549C5BA876.jpg""
        }
      ],
      ""weatherInfo"": ""New England weather can be quite unpredictable, so check the regional weather forecasts before you plan your trip. Winters can range in temperature from 20 - 50 degrees Fahrenheit. Summers are quite humid and range in temperature from 60 - 90 degrees Fahrenheit. Beware of ticks as they can be active year round."",
      ""name"": ""Minute Man"",
      ""designation"": ""National Historical Park"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""848DFACA-B486-4BC4-AD71-C834F7713793"",
      ""url"": ""https://www.nps.gov/nebe/index.htm"",
      ""fullName"": ""New Bedford Whaling National Historical Park"",
      ""parkCode"": ""nebe"",
      ""description"": ""\""The town itself is perhaps the dearest place to live in, in all New England..nowhere in all America will you find more patrician-like houses, parks and gardens more opulent, than in New Bedford�all these brave houses and flowery gardens came from the Atlantic, Pacific, and Indian oceans. One and all, they were harpooned and dragged up hither from the bottom of the sea.\"" H. Melville, \""Moby-Dick\"""",
      ""latitude"": ""41.63540552"",
      ""longitude"": ""-70.92322321"",
      ""latLong"": ""lat:41.63540552, long:-70.92322321"",
      ""activities"": [
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""24380E3F-AD9D-4E38-BF13-C8EEB21893E7"",
          ""name"": ""Shopping""
        },
        {
          ""id"": ""467DC8B8-0B7D-436D-A026-80A22358F615"",
          ""name"": ""Bookstore and Park Store""
        }
      ],
      ""topics"": [
        {
          ""id"": ""69693007-2DF2-4EDE-BB3B-A25EBA72BDF5"",
          ""name"": ""Architecture and Building""
        },
        {
          ""id"": ""28AEAE85-9DDA-45B6-981B-1CFCDCC61E14"",
          ""name"": ""African American Heritage""
        },
        {
          ""id"": ""00F3C3F9-2D67-4802-81AE-CCEA5D3BA370"",
          ""name"": ""Arts""
        },
        {
          ""id"": ""12EA2B56-17EC-410A-A10D-BFBA87A0669B"",
          ""name"": ""Explorers and Expeditions""
        },
        {
          ""id"": ""2B428F59-9148-40C1-B38E-130589F2540E"",
          ""name"": ""Immigration""
        },
        {
          ""id"": ""14FA9FF3-7D86-4406-9A6D-BE9032A1C578"",
          ""name"": ""Laborer and Worker""
        },
        {
          ""id"": ""1F95D138-CE10-40B5-95D0-B5BE4133B3A1"",
          ""name"": ""Migrant Workers""
        },
        {
          ""id"": ""4C9D4777-A9DA-47D1-A0B9-F4A3C98BC1B3"",
          ""name"": ""Maritime""
        },
        {
          ""id"": ""A079385C-3E71-4E18-9E42-B046BC22EA95"",
          ""name"": ""Ships and Shipwrecks""
        },
        {
          ""id"": ""A1BAF33E-EA84-4608-A888-4CEE9541F027"",
          ""name"": ""Native American Heritage""
        },
        {
          ""id"": ""272549CF-EAA4-4603-8E20-FBE1AAB391B7"",
          ""name"": ""Pacific Islander Heritage""
        },
        {
          ""id"": ""518B32FB-339D-4C52-B2C2-04BF406AA4B0"",
          ""name"": ""Religion and Spirituality""
        },
        {
          ""id"": ""98F41FDF-B73F-4B68-8010-53CCB2891E3B"",
          ""name"": ""Churches""
        },
        {
          ""id"": ""3CDB67A9-1EAC-408D-88EC-F26FA35E90AF"",
          ""name"": ""Schools and Education""
        },
        {
          ""id"": ""40C0866A-3890-41A4-84CA-5935DEE181AE"",
          ""name"": ""Social Movements""
        },
        {
          ""id"": ""5CCB14BC-2AC4-45CE-B786-54A065DA1B60"",
          ""name"": ""Abolition Movement""
        },
        {
          ""id"": ""8F34C3EC-7B8E-4F28-8114-B8DFE4F300DF"",
          ""name"": ""Civil Rights""
        },
        {
          ""id"": ""FE2C2613-B41E-4531-BC43-03EB6E45CBCF"",
          ""name"": ""Transportation""
        },
        {
          ""id"": ""0BBD4A42-2B3D-4E82-B5C4-1A3874C8682E"",
          ""name"": ""Roads, Routes and Highways""
        },
        {
          ""id"": ""846E5C56-E5AC-489C-B3BF-11F4C73F12C2"",
          ""name"": ""Urban America""
        },
        {
          ""id"": ""27BF8807-54EA-4A3D-B073-AA7AA361CD7E"",
          ""name"": ""Wars and Conflicts""
        },
        {
          ""id"": ""A8E54356-20CD-490E-B34D-AC6A430E6F47"",
          ""name"": ""Civil War""
        },
        {
          ""id"": ""7DA81DAB-5045-4953-9C20-36590AD9FA95"",
          ""name"": ""Women's History""
        },
        {
          ""id"": ""0E6D8503-CB65-467F-BCD6-C6D9E28A4E0B"",
          ""name"": ""Oceans""
        },
        {
          ""id"": ""980D1693-65BF-4F29-8182-7BAC9796E605"",
          ""name"": ""Whales""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""508-996-4095"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""nebe_info@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""From I-195 East or West take Exit 15 (Route 18 / Downtown). Take exit 15 to merge onto MA-18 S toward Downtown/New Bedford Continue straight onto MA-18 Turn right at the first set of lights, Elm St. Turn left onto Acushnet Ave Turn left onto William St Destination will be on the left"",
      ""directionsUrl"": ""https://www.nps.gov/nebe/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""10:00AM - 4:00PM"",
                ""monday"": ""10:00AM - 4:00PM"",
                ""thursday"": ""10:00AM - 4:00PM"",
                ""sunday"": ""10:00AM - 4:00PM"",
                ""tuesday"": ""10:00AM - 4:00PM"",
                ""friday"": ""10:00AM - 4:00PM"",
                ""saturday"": ""10:00AM - 4:00PM""
              },
              ""startDate"": ""2024-07-04"",
              ""name"": ""Independence Day"",
              ""endDate"": ""2024-07-04""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving Day"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""Closed"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Years Day"",
              ""endDate"": ""2025-01-01""
            }
          ],
          ""description"": ""New Bedford Whaling National Historical Park, situated in the heart of the City of New Bedford, is an urban oasis within the National Park system. Due to the distinct location of the Visitor Center and Garden, the operating hours may differ from those of the park boundary and city grounds. It's important to note that park partners and local businesses also have separate operating hours from the National Park Visitor Center.\n\nHolidays:\nClosed on Thanksgiving Day, Christmas Day, and New Year�s Day"",
          ""standardHours"": {
            ""wednesday"": ""9:00AM - 4:00PM"",
            ""monday"": ""Closed"",
            ""thursday"": ""9:00AM - 4:00PM"",
            ""sunday"": ""9:00AM - 4:00PM"",
            ""tuesday"": ""Closed"",
            ""friday"": ""9:00AM - 4:00PM"",
            ""saturday"": ""9:00AM - 4:00PM""
          },
          ""name"": ""New Bedford Whaling National Historical Park""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""02740"",
          ""city"": ""New Bedford"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""33 William Street"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": """"
        },
        {
          ""postalCode"": ""02740"",
          ""city"": ""New Bedford"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""33 William Street"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": """"
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""National Park Visitor Center"",
          ""altText"": ""New Bedford Whaling National Historical Park Visitor Center on a bright fall day."",
          ""caption"": ""New Bedford Whaling National Historical Park Visitor Center on a bright fall day."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C7B58A6-1DD8-B71B-0BECE805AD9FBFDA.png""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Seamen's Bethel and the Mariners' Home"",
          ""altText"": ""Semen's Bethel and the Mariners' Home on a sunny day"",
          ""caption"": ""Semen's Bethel and Mariners' Home"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C81A662-1DD8-B71B-0B35DB2B943F6F4D.jpg""
        },
        {
          ""credit"": ""NPS Photo/Jason Taylor"",
          ""title"": ""Sunset Overlooking New Bedfords Harbor"",
          ""altText"": ""The sun setting over the Acushnet River in New Bedford."",
          ""caption"": ""The sun setting over the Acushnet River in New Bedford."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/8DE29B7D-ED87-CCC8-1327142E3E0BF84D.jpeg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Rodman Candleworks"",
          ""altText"": ""Sun shining on the front of Rodman Candleworks"",
          ""caption"": ""Rodman Candleworks"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/95BD93FC-B5C3-BCC5-A50910150668BC71.jpg""
        }
      ],
      ""weatherInfo"": ""Summer temperatures range from 56-83F. Fall temperatures range from 30-70F. Winter temperatures range from 20-45F. Spring temperatures range from 30-70F."",
      ""name"": ""New Bedford Whaling"",
      ""designation"": ""National Historical Park"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""CF83E09C-3E55-4B5A-9D8B-E833CF6FEB5A"",
      ""url"": ""https://www.nps.gov/neen/index.htm"",
      ""fullName"": ""New England National Scenic Trail"",
      ""parkCode"": ""neen"",
      ""description"": ""From the Sound to the summits: the New England Trail covers 235 miles from Long Island Sound across long ridges to scenic mountain summits in Connecticut and Massachusetts. The trail offers panoramic vistas and close-ups of New England�s natural and cultural landscape: traprock ridges, historic village centers, farmlands, unfragmented forests, quiet streams, steep river valleys and waterfalls."",
      ""latitude"": ""42.2915819137"",
      ""longitude"": ""-72.5242767334"",
      ""latLong"": ""lat:42.2915819137, long:-72.5242767334"",
      ""activities"": [
        {
          ""id"": ""A59947B7-3376-49B4-AD02-C0423E08C5F7"",
          ""name"": ""Camping""
        },
        {
          ""id"": ""4A58AF13-E8FB-4530-B41A-97DF0B0C77B7"",
          ""name"": ""Backcountry Camping""
        },
        {
          ""id"": ""1DFACD97-1B9C-4F5A-80F2-05593604799E"",
          ""name"": ""Food""
        },
        {
          ""id"": ""E53E1320-9B17-41DC-86A5-37EB7D622572"",
          ""name"": ""Dining""
        },
        {
          ""id"": ""BFF8C027-7C8F-480B-A5F8-CD8CE490BFBA"",
          ""name"": ""Hiking""
        },
        {
          ""id"": ""7C37B79B-D02D-49EB-9020-3DB8299B748A"",
          ""name"": ""Backcountry Hiking""
        },
        {
          ""id"": ""45261C0A-00D8-4C27-A1F8-029F933A0D34"",
          ""name"": ""Front-Country Hiking""
        },
        {
          ""id"": ""01D717BC-18BB-4FE4-95BA-6B13AD702038"",
          ""name"": ""Snowshoeing""
        }
      ],
      ""topics"": [
        {
          ""id"": ""0D00073E-18C3-46E5-8727-2F87B112DDC6"",
          ""name"": ""Animals""
        },
        {
          ""id"": ""41B1A0A3-11FF-4F55-9CB9-034A7E28B087"",
          ""name"": ""Forests and Woodlands""
        },
        {
          ""id"": ""F8C2FE93-DEB3-4B12-9A87-913E3E6B448D"",
          ""name"": ""Natural Sounds""
        },
        {
          ""id"": ""A7359FC4-DAD8-45F5-AF15-7FF62F816ED3"",
          ""name"": ""Night Sky""
        },
        {
          ""id"": ""9C9FCBB6-360B-4743-8155-6F9341CBE01B"",
          ""name"": ""Scenic Views""
        },
        {
          ""id"": ""5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417"",
          ""name"": ""Trails""
        },
        {
          ""id"": ""5ED826E0-76BB-47BB-87DD-E081A72B0A04"",
          ""name"": ""Waterfalls""
        },
        {
          ""id"": ""B85866E2-0897-4000-9040-605CA335804F"",
          ""name"": ""Wilderness""
        }
      ],
      ""states"": ""MA,CT"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""413-351-8182"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": ""For information regarding the NET in Massachusetts, contact Miriam Maistelman at mmaistelman@outdoors.org.\n\nFor information regarding the NET in Connecticut, contact Clare Cain at ccain@ctwoodlands.org"",
            ""emailAddress"": ""net@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""More than 100 public roads cross the New England Trail, and there are trail head parking areas at or near many of these crossings. Detailed Trail Maps are available from Appalachian Mountain Club and Connecticut Forest & Park Association. For Massachusetts maps, visit the AMC Berkshire Chapter; for Connecticut, visit the CFPA Bookstore. Direct access by bus is available at several points in Connecticut and Massachusetts. Train service is available at two points � in Guilford, CT and Northampton, MA."",
      ""directionsUrl"": ""https://newenglandtrail.org/interactive-map/"",
      ""operatingHours"": [
        {
          ""exceptions"": [],
          ""description"": ""As the New England trail crosses private property and state land, many locations along the trail do not permit night hiking or overnight parking. Before going out on a hike, check the hours of local parks for parking and hiking regulations."",
          ""standardHours"": {
            ""wednesday"": ""Sunrise to Sunset"",
            ""monday"": ""Sunrise to Sunset"",
            ""thursday"": ""Sunrise to Sunset"",
            ""sunday"": ""Sunrise to Sunset"",
            ""tuesday"": ""Sunrise to Sunset"",
            ""friday"": ""Sunrise to Sunset"",
            ""saturday"": ""Sunrise to Sunset""
          },
          ""name"": ""New England Trail Hours""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""01105"",
          ""city"": ""Springfield"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""New England Trail"",
          ""type"": ""Physical"",
          ""line3"": ""One Armory Square, Suite 2"",
          ""line2"": ""c/o Springfield Armory National Historic Site""
        },
        {
          ""postalCode"": ""01105"",
          ""city"": ""Springfield"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""New England Trail"",
          ""type"": ""Mailing"",
          ""line3"": ""One Armory Square, Suite 2"",
          ""line2"": ""c/o Springfield Armory National Historic Site""
        }
      ],
      ""images"": [
        {
          ""credit"": ""AMC Photo"",
          ""title"": ""Sunset on the trail"",
          ""altText"": ""Hiker in trees at overlook with sunset in background"",
          ""caption"": ""Scenic views on the New England Trail"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/498B6E55-9C9A-07E3-AB0896A77C5485DD.jpg""
        },
        {
          ""credit"": ""Xiomaro"",
          ""title"": ""Fall on the NET"",
          ""altText"": ""Fall trees on the mountains of the trail"",
          ""caption"": ""Fall on the New England Trail"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/62EEBADD-1DD8-B71B-0B610F999ED4F0F5.jpg""
        },
        {
          ""credit"": ""Xiomaro"",
          ""title"": ""Mt Tom Overlook"",
          ""altText"": ""Overview of the trail in the fall"",
          ""caption"": ""Mount Tom Overlook"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/62D44561-1DD8-B71B-0B2578338FED38F1.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""NET College Network Retreat"",
          ""altText"": ""Youth gather around a trail head"",
          ""caption"": ""Youth hike to Farley Ledge"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/62F72936-1DD8-B71B-0B5B48155625FADB.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""YAP on Mt Higby"",
          ""altText"": ""Two youth pointing out over the trail from the top of Mt Higby"",
          ""caption"": ""Hikers pointing out over Mount Higby"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/635981EA-1DD8-B71B-0B7883BC650623A0.jpg""
        }
      ],
      ""weatherInfo"": ""Temperatures range from warm, humid summer days to cold New England winter days."",
      ""name"": ""New England"",
      ""designation"": ""National Scenic Trail"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""3C5998C3-F130-4E4C-8BA4-C1B25E728CE0"",
      ""url"": ""https://www.nps.gov/sama/index.htm"",
      ""fullName"": ""Salem Maritime National Historic Site"",
      ""parkCode"": ""sama"",
      ""description"": ""Established on March 17, 1938 as the first National Historic Site in the United States, Salem Maritime National Historic Site consists of nine acres of land and twelve historic structures along the Salem waterfront, as well as a downtown visitor center. Located in the urban setting of Salem, the park preserves and interprets over 600 years of New England's maritime history and global connections."",
      ""latitude"": ""42.52024529"",
      ""longitude"": ""-70.88640867"",
      ""latLong"": ""lat:42.52024529, long:-70.88640867"",
      ""activities"": [
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""A0631906-9672-4583-91DE-113B93DB6B6E"",
          ""name"": ""Self-Guided Tours - Walking""
        },
        {
          ""id"": ""C7D5A145-F8EB-4C37-9E92-2F6C6206B196"",
          ""name"": ""Self-Guided Tours - Auto""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""0C0D142F-06B5-4BE1-8B44-491B90F93DEB"",
          ""name"": ""Park Film""
        },
        {
          ""id"": ""C8F98B28-3C10-41AE-AA99-092B3B398C43"",
          ""name"": ""Museum Exhibits""
        },
        {
          ""id"": ""24380E3F-AD9D-4E38-BF13-C8EEB21893E7"",
          ""name"": ""Shopping""
        },
        {
          ""id"": ""467DC8B8-0B7D-436D-A026-80A22358F615"",
          ""name"": ""Bookstore and Park Store""
        },
        {
          ""id"": ""43800AD1-D439-40F3-AAB3-9FB651FE45BB"",
          ""name"": ""Gift Shop and Souvenirs""
        }
      ],
      ""topics"": [
        {
          ""id"": ""69693007-2DF2-4EDE-BB3B-A25EBA72BDF5"",
          ""name"": ""Architecture and Building""
        },
        {
          ""id"": ""28AEAE85-9DDA-45B6-981B-1CFCDCC61E14"",
          ""name"": ""African American Heritage""
        },
        {
          ""id"": ""F3883A66-A7CB-461B-868E-1B5932224B25"",
          ""name"": ""American Revolution""
        },
        {
          ""id"": ""00F3C3F9-2D67-4802-81AE-CCEA5D3BA370"",
          ""name"": ""Arts""
        },
        {
          ""id"": ""156AD9B6-B377-418C-BC9A-F6E682D4BAF7"",
          ""name"": ""Poetry and Literature""
        },
        {
          ""id"": ""1170EEB6-5070-4760-8E7D-FF1A98272FAD"",
          ""name"": ""Commerce""
        },
        {
          ""id"": ""A010EADF-78B8-4526-B0A4-70B0E0B3470E"",
          ""name"": ""Trade""
        },
        {
          ""id"": ""D9FC6D14-F8C7-4EBA-86EA-DFD99B6BB4F5"",
          ""name"": ""Enslavement""
        },
        {
          ""id"": ""2B428F59-9148-40C1-B38E-130589F2540E"",
          ""name"": ""Immigration""
        },
        {
          ""id"": ""4C9D4777-A9DA-47D1-A0B9-F4A3C98BC1B3"",
          ""name"": ""Maritime""
        },
        {
          ""id"": ""7424754D-EB8B-4608-A69A-50D44992931B"",
          ""name"": ""Maritime - Military""
        },
        {
          ""id"": ""263BAC6E-4DEC-47E4-909D-DA8AD351E06E"",
          ""name"": ""Lighthouses""
        },
        {
          ""id"": ""78CF2074-0EE5-48F1-AD0F-B39C6C5A447B"",
          ""name"": ""Piracy and Privateering""
        },
        {
          ""id"": ""A079385C-3E71-4E18-9E42-B046BC22EA95"",
          ""name"": ""Ships and Shipwrecks""
        },
        {
          ""id"": ""3B0D607D-9933-425A-BFA0-21529AC4734C"",
          ""name"": ""Military""
        },
        {
          ""id"": ""2ACF7D12-91EA-4981-A1B7-AD0A186B6800"",
          ""name"": ""Armories""
        },
        {
          ""id"": ""40C0866A-3890-41A4-84CA-5935DEE181AE"",
          ""name"": ""Social Movements""
        },
        {
          ""id"": ""4C0EBDE7-EB73-4252-84D9-0650974EC3E5"",
          ""name"": ""Conservation Movement""
        },
        {
          ""id"": ""FE2C2613-B41E-4531-BC43-03EB6E45CBCF"",
          ""name"": ""Transportation""
        },
        {
          ""id"": ""FB3641FE-67A3-4EC7-B9C4-0A0867776798"",
          ""name"": ""Ancient Seas""
        },
        {
          ""id"": ""0D00073E-18C3-46E5-8727-2F87B112DDC6"",
          ""name"": ""Animals""
        },
        {
          ""id"": ""4DC11D06-00F1-4A01-81D0-89CCCCE4FF50"",
          ""name"": ""Climate Change""
        },
        {
          ""id"": ""0E6D8503-CB65-467F-BCD6-C6D9E28A4E0B"",
          ""name"": ""Oceans""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""978-740-1650"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          },
          {
            ""phoneNumber"": ""978-740-1654"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Fax""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""SAMA_Information@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""Salem Maritime National Historic Site is located in downtown Salem, Massachusetts and is accessible by vehicle, commuter rail, bus, ferry, and recreational boat."",
      ""directionsUrl"": ""https://www.nps.gov/sama/planyourvisit/directions-transportation.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [],
          ""description"": ""All outdoor spaces including the grounds, gardens, waterfront, and wharves are accessible 7 days a week. Please check the Visitor Center hours to learn more about which facilities are open."",
          ""standardHours"": {
            ""wednesday"": ""All Day"",
            ""monday"": ""All Day"",
            ""thursday"": ""All Day"",
            ""sunday"": ""All Day"",
            ""tuesday"": ""All Day"",
            ""friday"": ""All Day"",
            ""saturday"": ""All Day""
          },
          ""name"": ""Park Grounds""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""01970"",
          ""city"": ""Salem"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""Salem Armory Visitor Center"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": ""2 New Liberty Street""
        },
        {
          ""postalCode"": ""01970"",
          ""city"": ""Salem"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""160 Derby Street"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": """"
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo / Robert Grant"",
          ""title"": ""Friendship of Salem"",
          ""altText"": ""A three mast tall ship on the water under a blue sky with red brick buildings on the shore."",
          ""caption"": ""Park Waterfront & Vessel Friendship of Salem"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C852B17-1DD8-B71B-0BB86A151B7BE502.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Custom House"",
          ""altText"": ""Three story red brick building with white columns has a wide staircase and golden eagle on top."",
          ""caption"": ""This Custom House was built in 1819 and housed offices for the officers of the U.S. Customs Service, as well as an attached warehouse, the Public Stores, used for the storage of bonded and impounded cargo."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/81A1A135-D07F-2401-575D27AEB50757EA.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Derby Wharf Light"",
          ""altText"": ""A white rectangular lighthouse approximately 20 feet tall is near the water on a gravel road."",
          ""caption"": ""The Derby Wharf Light Station has aided navigation in Salem Harbor since it was first lit in 1871."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/81B85D8A-B8FC-4C60-5D86719450CFA7BA.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Derby House"",
          ""altText"": ""Three story red brick building with white windows and a brick pathway through grasses and trees."",
          ""caption"": ""Built in 1762 as a wedding present, the Derby House was the home of Elias Hasket Derby (1739-1799) and Elizabeth Crowninshield Derby (1727-1799) for the first twenty years of their marriage."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/81E50923-C71A-94BD-7BAFD64C112DB4CE.jpg""
        }
      ],
      ""weatherInfo"": ""New England weather is unpredictable year-round. Monthly averages, in degrees Fahrenheit, are: January: 37 high, 20 low February: 40 high, 23 low March: 47 high, 30 low April: 57 high, 38 low May: 67 high, 48 low June: 76 high, 58 low July: 82 high, 63 low August: 80 high, 62 low September: 73 high, 55 low October: 62 high, 45 low November: 52 high, 37 low December: 42 high, 27 low"",
      ""name"": ""Salem Maritime"",
      ""designation"": ""National Historic Site"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""A83EFD38-9FCF-4996-A957-FE416A8C6B6D"",
      ""url"": ""https://www.nps.gov/sair/index.htm"",
      ""fullName"": ""Saugus Iron Works National Historic Site"",
      ""parkCode"": ""sair"",
      ""description"": ""In the 1600's, on the banks of the Saugus River, something extraordinary happened! Explore the place where European iron makers brought their special skills to a young Massachusetts colony. Saugus Iron Works is a twelve-acre National Historic Site that includes working waterwheels, forges, mills, a historic 17th century home, and a lush river basin."",
      ""latitude"": ""42.46830664"",
      ""longitude"": ""-71.0076953"",
      ""latLong"": ""lat:42.46830664, long:-71.0076953"",
      ""activities"": [
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""0C0D142F-06B5-4BE1-8B44-491B90F93DEB"",
          ""name"": ""Park Film""
        },
        {
          ""id"": ""C8F98B28-3C10-41AE-AA99-092B3B398C43"",
          ""name"": ""Museum Exhibits""
        },
        {
          ""id"": ""24380E3F-AD9D-4E38-BF13-C8EEB21893E7"",
          ""name"": ""Shopping""
        },
        {
          ""id"": ""467DC8B8-0B7D-436D-A026-80A22358F615"",
          ""name"": ""Bookstore and Park Store""
        }
      ],
      ""topics"": [
        {
          ""id"": ""7F81A0CB-B91F-4896-B9A5-41BE9A54A27B"",
          ""name"": ""Archeology""
        },
        {
          ""id"": ""7F12224B-217A-4B07-A4A2-636B1CE7F221"",
          ""name"": ""Colonization and Settlement""
        },
        {
          ""id"": ""FE005582-12C5-472C-8229-3CB004DB050E"",
          ""name"": ""Engineering""
        },
        {
          ""id"": ""351EE154-87AA-46B0-BBA1-ED604368ACE9"",
          ""name"": ""Incarceration""
        },
        {
          ""id"": ""0B575E33-B68F-4F3D-998E-B03284606CF3"",
          ""name"": ""Industry""
        },
        {
          ""id"": ""14FA9FF3-7D86-4406-9A6D-BE9032A1C578"",
          ""name"": ""Laborer and Worker""
        },
        {
          ""id"": ""518B32FB-339D-4C52-B2C2-04BF406AA4B0"",
          ""name"": ""Religion and Spirituality""
        },
        {
          ""id"": ""3CDB67A9-1EAC-408D-88EC-F26FA35E90AF"",
          ""name"": ""Schools and Education""
        },
        {
          ""id"": ""D1CF31DE-AFED-412B-9425-DD1FD4CBB5C7"",
          ""name"": ""Science, Technology and Innovation""
        },
        {
          ""id"": ""0D00073E-18C3-46E5-8727-2F87B112DDC6"",
          ""name"": ""Animals""
        },
        {
          ""id"": ""5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417"",
          ""name"": ""Trails""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""781-233-0050"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""SAMA_Information@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""The park is accessible via Interstate 95 (Walnut St.) and Route 1 (Main St. / Walnut St.). Public transportation options are available through the Massachusetts Bay Transportation Authority (MBTA)."",
      ""directionsUrl"": ""https://www.nps.gov/sair/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [],
          ""description"": ""All outdoor spaces including the grounds and walking paths are accessible 7 days a week. Please check the visitor center hours to learn more about which facilities are open."",
          ""standardHours"": {
            ""wednesday"": ""All Day"",
            ""monday"": ""All Day"",
            ""thursday"": ""All Day"",
            ""sunday"": ""All Day"",
            ""tuesday"": ""All Day"",
            ""friday"": ""All Day"",
            ""saturday"": ""All Day""
          },
          ""name"": ""Park Grounds""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""01906"",
          ""city"": ""Saugus"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""244 Central St"",
          ""type"": ""Physical"",
          ""line3"": """",
          ""line2"": """"
        },
        {
          ""postalCode"": ""01906"",
          ""city"": ""Saugus"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""244 Central St"",
          ""type"": ""Mailing"",
          ""line3"": """",
          ""line2"": """"
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo / Don Woods"",
          ""title"": ""Saugus Iron Works Landscape"",
          ""altText"": ""Several wooden structures amid green fields and trees under partly cloudy sky and beside river."",
          ""caption"": ""A view of Saugus Iron Works from the Saugus River"",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/3C852E9B-1DD8-B71B-0BA7396E0D076BDB.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Iron Forge"",
          ""altText"": ""Approximately 15' by 15' spoked wooden wheel beside river and under blue sky."",
          ""caption"": ""The forge is where bars of pig iron created at the blast furnace were changed into a new kind of iron that a blacksmith was able to use."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/838FD1C1-064E-FCB5-82DE23B12CF51362.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Blast Furnace"",
          ""altText"": ""Rectangular wooden structure between orange deciduous trees and wooden bridge with walkway."",
          ""caption"": ""The blast furnace is where bog ore was smelted to create cast iron \""pig\"" bars."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/83A5CA79-099C-220B-DD37490775CD89C4.jpg""
        }
      ],
      ""weatherInfo"": ""New England weather is unpredictable year-round. Monthly averages, in degrees Fahrenheit, are: January: 37 high, 20 low February: 40 high, 23 low March: 47 high, 30 low April: 57 high, 38 low May: 67 high, 48 low June: 76 high, 58 low July: 82 high, 63 low August: 80 high, 62 low September: 73 high, 55 low October: 62 high, 45 low November: 52 high, 37 low December: 42 high, 27 low"",
      ""name"": ""Saugus Iron Works"",
      ""designation"": ""National Historic Site"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""E01A7425-C74B-4E71-853D-681AD2FB948A"",
      ""url"": ""https://www.nps.gov/spar/index.htm"",
      ""fullName"": ""Springfield Armory National Historic Site"",
      ""parkCode"": ""spar"",
      ""description"": ""For nearly two centuries, the U.S. Armed Forces and American industry looked to Springfield Armory for innovative engineering and superior firearms. Springfield Armory National Historic Site commemorates the critical role of the nation�s first armory by preserving and interpreting the world's largest historic US military small arms collection, along with historic archives, buildings and landscape."",
      ""latitude"": ""42.1086368"",
      ""longitude"": ""-72.57967415"",
      ""latLong"": ""lat:42.1086368, long:-72.57967415"",
      ""activities"": [
        {
          ""id"": ""FAED7F97-3474-4C21-AB42-FB0768A2F826"",
          ""name"": ""Cultural Demonstrations""
        },
        {
          ""id"": ""B33DC9B6-0B7D-4322-BAD7-A13A34C584A3"",
          ""name"": ""Guided Tours""
        },
        {
          ""id"": ""237A1662-6018-4115-ABD1-B8CCF827E703"",
          ""name"": ""Historic Weapons Demonstration""
        },
        {
          ""id"": ""DF4A35E0-7983-4A3E-BC47-F37B872B0F25"",
          ""name"": ""Junior Ranger Program""
        },
        {
          ""id"": ""0C0D142F-06B5-4BE1-8B44-491B90F93DEB"",
          ""name"": ""Park Film""
        },
        {
          ""id"": ""C8F98B28-3C10-41AE-AA99-092B3B398C43"",
          ""name"": ""Museum Exhibits""
        },
        {
          ""id"": ""24380E3F-AD9D-4E38-BF13-C8EEB21893E7"",
          ""name"": ""Shopping""
        },
        {
          ""id"": ""467DC8B8-0B7D-436D-A026-80A22358F615"",
          ""name"": ""Bookstore and Park Store""
        }
      ],
      ""topics"": [
        {
          ""id"": ""69693007-2DF2-4EDE-BB3B-A25EBA72BDF5"",
          ""name"": ""Architecture and Building""
        },
        {
          ""id"": ""28AEAE85-9DDA-45B6-981B-1CFCDCC61E14"",
          ""name"": ""African American Heritage""
        },
        {
          ""id"": ""F3883A66-A7CB-461B-868E-1B5932224B25"",
          ""name"": ""American Revolution""
        },
        {
          ""id"": ""D9FC6D14-F8C7-4EBA-86EA-DFD99B6BB4F5"",
          ""name"": ""Enslavement""
        },
        {
          ""id"": ""12EA2B56-17EC-410A-A10D-BFBA87A0669B"",
          ""name"": ""Explorers and Expeditions""
        },
        {
          ""id"": ""0B575E33-B68F-4F3D-998E-B03284606CF3"",
          ""name"": ""Industry""
        },
        {
          ""id"": ""AAF8795A-231B-4DA4-B564-AA51C95E72BD"",
          ""name"": ""Factories""
        },
        {
          ""id"": ""14FA9FF3-7D86-4406-9A6D-BE9032A1C578"",
          ""name"": ""Laborer and Worker""
        },
        {
          ""id"": ""7424754D-EB8B-4608-A69A-50D44992931B"",
          ""name"": ""Maritime - Military""
        },
        {
          ""id"": ""3B0D607D-9933-425A-BFA0-21529AC4734C"",
          ""name"": ""Military""
        },
        {
          ""id"": ""E411F474-A530-4804-9D23-1D94C78B41E4"",
          ""name"": ""Infantry and Militia""
        },
        {
          ""id"": ""B145FAB8-5462-4FE2-964E-464D3A5E7F96"",
          ""name"": ""Artillery""
        },
        {
          ""id"": ""69790851-A62A-4920-AA3E-E61406FFC27D"",
          ""name"": ""Cavalry""
        },
        {
          ""id"": ""97CCB419-196C-4B95-BB3A-621458F78415"",
          ""name"": ""US Army""
        },
        {
          ""id"": ""7A9F5EB5-4AE3-4A16-AFF0-E1F9FF2F8B32"",
          ""name"": ""US Navy""
        },
        {
          ""id"": ""64808223-DD03-40ED-99A1-76183E7AB1F5"",
          ""name"": ""US Marines""
        },
        {
          ""id"": ""D164D82F-4031-4BCB-90A8-B388502CA308"",
          ""name"": ""US Coast Guard""
        },
        {
          ""id"": ""83CEA23E-9FF6-4C6B-B48E-A725087D5CC5"",
          ""name"": ""US Air Force (Army Air Corps)""
        },
        {
          ""id"": ""6766B838-9493-4EF8-830E-2D1EFB917461"",
          ""name"": ""Indigenous and Native Warrior""
        },
        {
          ""id"": ""2ACF7D12-91EA-4981-A1B7-AD0A186B6800"",
          ""name"": ""Armories""
        },
        {
          ""id"": ""6A3658B4-FB6E-4E23-A63A-9AEF11988831"",
          ""name"": ""Battlefields""
        },
        {
          ""id"": ""A1BAF33E-EA84-4608-A888-4CEE9541F027"",
          ""name"": ""Native American Heritage""
        },
        {
          ""id"": ""F669BC40-BDC4-41C0-9ACE-B2CD25373045"",
          ""name"": ""Presidents""
        },
        {
          ""id"": ""D1CF31DE-AFED-412B-9425-DD1FD4CBB5C7"",
          ""name"": ""Science, Technology and Innovation""
        },
        {
          ""id"": ""846E5C56-E5AC-489C-B3BF-11F4C73F12C2"",
          ""name"": ""Urban America""
        },
        {
          ""id"": ""27BF8807-54EA-4A3D-B073-AA7AA361CD7E"",
          ""name"": ""Wars and Conflicts""
        },
        {
          ""id"": ""B564E9AA-95E9-4648-A7D1-48F94BFBEBB5"",
          ""name"": ""Tribal Conflicts""
        },
        {
          ""id"": ""3D2EE3E9-7344-416C-A412-C2C7CDCDE684"",
          ""name"": ""Colonial/European Contact Conflicts""
        },
        {
          ""id"": ""480D5BD7-D43B-44BB-AD82-1751CB859054"",
          ""name"": ""French and Indian War""
        },
        {
          ""id"": ""990E22A2-20D8-4CC2-8E6C-D2DF165BCDA5"",
          ""name"": ""American Revolutionary War""
        },
        {
          ""id"": ""F94E78D3-EC70-4B99-AB57-BC70C4E79D65"",
          ""name"": ""War of 1812""
        },
        {
          ""id"": ""E2D07F67-8499-4B0D-A079-14E93484C20F"",
          ""name"": ""Mexican War""
        },
        {
          ""id"": ""53798A16-7CDB-4F17-9C28-095F92D2ED8D"",
          ""name"": ""Indian and Frontier Wars""
        },
        {
          ""id"": ""A8E54356-20CD-490E-B34D-AC6A430E6F47"",
          ""name"": ""Civil War""
        },
        {
          ""id"": ""A28F8700-794E-4BA3-A8D7-7D75D53A4B17"",
          ""name"": ""Spanish-American War""
        },
        {
          ""id"": ""4EC51024-F0D9-479D-AF3F-344CC0153D2E"",
          ""name"": ""World War I""
        },
        {
          ""id"": ""74869FAE-8DFD-4454-847F-11FDDB679F94"",
          ""name"": ""World War II""
        },
        {
          ""id"": ""3A25C166-83B4-48A4-BB7B-BD67469D17B6"",
          ""name"": ""Korean War""
        },
        {
          ""id"": ""D2D3201A-8C12-4CD6-B47D-E982633C8524"",
          ""name"": ""Vietnam War""
        },
        {
          ""id"": ""A764E57D-9925-4855-8D66-C60357946FC3"",
          ""name"": ""Cold War""
        },
        {
          ""id"": ""7DA81DAB-5045-4953-9C20-36590AD9FA95"",
          ""name"": ""Women's History""
        }
      ],
      ""states"": ""MA"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""4137348551"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          },
          {
            ""phoneNumber"": ""4137478062"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Fax""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": """",
            ""emailAddress"": ""spar_interpretation@nps.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""The entrance to Armory Square is on Federal Street in Springfield, MA. Armory Square is shared by Springfield Armory NHS and Springfield Technical Community College (STCC). The park is located on the STCC campus. Follow the one way roadway around until you see the entrance sign for the park. If stopped by campus security let them know you are visiting the park. Parking is available in front of the Springfield Armory visitor center."",
      ""directionsUrl"": ""http://www.nps.gov/spar/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [
            {
              ""exceptionHours"": {
                ""wednesday"": ""Closed"",
                ""monday"": ""Closed"",
                ""thursday"": ""10:00AM - 2:00PM"",
                ""sunday"": ""Closed"",
                ""tuesday"": ""Closed"",
                ""friday"": ""Closed"",
                ""saturday"": ""Closed""
              },
              ""startDate"": ""2024-06-10"",
              ""name"": ""Construction Hours (Spring 2021)"",
              ""endDate"": ""2024-07-01""
            },
            {
              ""exceptionHours"": {},
              ""startDate"": ""2024-11-28"",
              ""name"": ""Thanksgiving Day"",
              ""endDate"": ""2024-11-28""
            },
            {
              ""exceptionHours"": {},
              ""startDate"": ""2024-12-25"",
              ""name"": ""Christmas Day"",
              ""endDate"": ""2024-12-25""
            },
            {
              ""exceptionHours"": {
                ""sunday"": ""Closed""
              },
              ""startDate"": ""2025-01-01"",
              ""name"": ""New Year's Day"",
              ""endDate"": ""2025-01-01""
            }
          ],
          ""description"": ""The Park MUSEUM & VISITOR CENTER\nThe Park is OPEN Wednesday through Sunday from 9:30am to 4:00pm. \nThe Park is CLOSED Monday and Tuesday\n\nThe park is closed for the following holidays:\n\n�New Year's Day\n�Thanksgiving Day\n�Christmas Day"",
          ""standardHours"": {
            ""wednesday"": ""9:30AM - 4:00PM"",
            ""monday"": ""Closed"",
            ""thursday"": ""9:30AM - 4:00PM"",
            ""sunday"": ""9:30AM - 4:00PM"",
            ""tuesday"": ""Closed"",
            ""friday"": ""9:30AM - 4:00PM"",
            ""saturday"": ""9:30AM - 4:00PM""
          },
          ""name"": ""Springfield Armory National Historic Site""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""01105"",
          ""city"": ""Springfield"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""Springfield Armory National Historic Site"",
          ""type"": ""Physical"",
          ""line3"": ""Suite 2"",
          ""line2"": ""One Armory Square""
        },
        {
          ""postalCode"": ""01105"",
          ""city"": ""Springfield"",
          ""stateCode"": ""MA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""Springfield Armory National Historic Site"",
          ""type"": ""Mailing"",
          ""line3"": ""Suite 2"",
          ""line2"": ""One Armory Square""
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Springfield Armory National Historic Site"",
          ""altText"": ""The Main Arsenal"",
          ""caption"": ""The Main Arsenal at Springfield Armory National Historic Site was first built in 1850 and today houses the park's amazing collection of historic firearms."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/D351A3D5-1DD8-B71B-0B9E169EA16305E9.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Blank Firing Demostration"",
          ""altText"": ""Three Park Volunteers, holding historic firearms, on the grounds of the Armory against a cloudy sky."",
          ""caption"": ""Park Volunteers give a blank firing demonstration of historic firearms."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/EE59D277-BB59-B95A-FE0BCA4D6B22DC70.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Springfield Armory Clock Tower"",
          ""altText"": ""The tower of the Armory with the flag at full mast blowing in the wind on a cloudy day."",
          ""caption"": ""Following the closure of the Springfield Armory in 1968, public action would drive Congress to create Springfield Armory National Historic Site in the late 1970s."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/EE8C00C2-BDE4-9CC3-2686707A304148B6.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Organ of Muskets"",
          ""altText"": ""A double musket rack holding 645 Springfield US Model 1861 rifle muskets."",
          ""caption"": ""Named after a poem by Henry Wadsworth Longfellow, the Organ of Muskets consists of 647 Model 1861 Rifle Muskets. This structure would have held 1100 muskets when fully stocked and would have been one of many that filled the Arsenal during the Civil War."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/EF74A0C2-E271-6041-2D2A097B9A5D86A4.jpg""
        },
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Springfield Main Arsenal on a Fall Day"",
          ""altText"": ""The Springfield Armory Main Arsenal on a fall day, with blue skies and the flag at half staff."",
          ""caption"": ""Springfield Armory began the production of small arms in 1794 and continued until its close in 1968. In 1978, the Armory reopened under the direction of the National Park Service as a National Historic Site."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/EF9A4AF9-EFC3-BF6E-7224498221C4EB81.jpg""
        }
      ],
      ""weatherInfo"": ""Springfield Armory National Historic Site is situated in the heart of Western Massachusetts and the Pioneer Valley. Our year is marked by four distinct seasons. Summers tend to be pleasant, but can at times be very hot and very humid. Autumn features brilliant foliage and cooler, calmer weather. Winter storms are capable of closing the park and can make travel dangerous. Springtime in New England is pleasant."",
      ""name"": ""Springfield Armory"",
      ""designation"": ""National Historic Site"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    },
    {
      ""id"": ""3D547E73-F0BF-4FEA-9CAC-9611D024E2FF"",
      ""url"": ""https://www.nps.gov/waro/index.htm"",
      ""fullName"": ""Washington-Rochambeau Revolutionary Route National Historic Trail"",
      ""parkCode"": ""waro"",
      ""description"": ""In 1781, General Rochambeau�s French Army joined forces with General Washington�s Continental Army to fight the British Army in Yorktown, Virginia. With the French Navy in support, the allied armies moved hundreds of miles to become the largest troop movement of the American Revolution. The effort and cooperation between the two sides led to a victory at Yorktown and secured American independence."",
      ""latitude"": ""40.0958204557"",
      ""longitude"": ""-74.8563515109"",
      ""latLong"": ""lat:40.0958204557, long:-74.8563515109"",
      ""activities"": [],
      ""topics"": [
        {
          ""id"": ""F3883A66-A7CB-461B-868E-1B5932224B25"",
          ""name"": ""American Revolution""
        },
        {
          ""id"": ""4C9D4777-A9DA-47D1-A0B9-F4A3C98BC1B3"",
          ""name"": ""Maritime""
        },
        {
          ""id"": ""7424754D-EB8B-4608-A69A-50D44992931B"",
          ""name"": ""Maritime - Military""
        },
        {
          ""id"": ""3B0D607D-9933-425A-BFA0-21529AC4734C"",
          ""name"": ""Military""
        },
        {
          ""id"": ""FE2C2613-B41E-4531-BC43-03EB6E45CBCF"",
          ""name"": ""Transportation""
        },
        {
          ""id"": ""0BBD4A42-2B3D-4E82-B5C4-1A3874C8682E"",
          ""name"": ""Roads, Routes and Highways""
        },
        {
          ""id"": ""27BF8807-54EA-4A3D-B073-AA7AA361CD7E"",
          ""name"": ""Wars and Conflicts""
        },
        {
          ""id"": ""990E22A2-20D8-4CC2-8E6C-D2DF165BCDA5"",
          ""name"": ""American Revolutionary War""
        },
        {
          ""id"": ""5BE55D7F-BDB6-4E3D-AC35-2D8EBB974417"",
          ""name"": ""Trails""
        },
        {
          ""id"": ""596BAA6D-F66B-4348-8433-FEFF35A8005E"",
          ""name"": ""Water Trails""
        }
      ],
      ""states"": ""MA,RI,CT,NY,NJ,PA,DE,MD,VA,DC"",
      ""contacts"": {
        ""phoneNumbers"": [
          {
            ""phoneNumber"": ""610-783-1006"",
            ""description"": """",
            ""extension"": """",
            ""type"": ""Voice""
          }
        ],
        ""emailAddresses"": [
          {
            ""description"": ""Washington-Rochambeau National Historic Trail"",
            ""emailAddress"": ""Johnny_Carawan@NPS.gov""
          }
        ]
      },
      ""entranceFees"": [],
      ""entrancePasses"": [],
      ""fees"": [],
      ""directionsInfo"": ""The Washington-Rochambeau Revolutionary Route National Historic Trail encompasses over 680 miles of land and water trails through Rhode Island, Massachusetts, Connecticut, New York, New Jersey, Pennsylvania, Delaware, Maryland, Washington D.C., and Virginia"",
      ""directionsUrl"": ""http://www.nps.gov/waro/planyourvisit/directions.htm"",
      ""operatingHours"": [
        {
          ""exceptions"": [],
          ""description"": ""The Washington-Rochambeau Revolutionary Route NHT can be travelled year-round. The NHT connects national, state, and local parks as well a great number of historic sites and landmarks. Visitors should contact sites or attractions individually as operating hours vary widely by site and season."",
          ""standardHours"": {
            ""wednesday"": ""All Day"",
            ""monday"": ""All Day"",
            ""thursday"": ""All Day"",
            ""sunday"": ""All Day"",
            ""tuesday"": ""All Day"",
            ""friday"": ""All Day"",
            ""saturday"": ""All Day""
          },
          ""name"": ""Washington-Rochamebeau National Historic Trail""
        }
      ],
      ""addresses"": [
        {
          ""postalCode"": ""19406"",
          ""city"": ""King of Prussia"",
          ""stateCode"": ""PA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""Washington-Rochambeau National Historic Trail"",
          ""type"": ""Physical"",
          ""line3"": ""1400 North Outer Line Drive"",
          ""line2"": ""Make requests of Trail Administrator at Johnny_Carawan@NPS.gov""
        },
        {
          ""postalCode"": ""19406"",
          ""city"": ""King of Prussia"",
          ""stateCode"": ""PA"",
          ""countryCode"": ""US"",
          ""provinceTerritoryCode"": """",
          ""line1"": ""Washington-Rochambeau National Historic Trail"",
          ""type"": ""Mailing"",
          ""line3"": ""1400 North Outer Line Drive"",
          ""line2"": """"
        }
      ],
      ""images"": [
        {
          ""credit"": ""NPS Photo"",
          ""title"": ""Washington Rochambeau"",
          ""altText"": ""Flag marking the trail"",
          ""caption"": ""Washington-Rochambeau NHT banner on 2nd Street in Philadelphia, Pennsylvania."",
          ""url"": ""https://www.nps.gov/common/uploads/structured_data/38D13B48-1DD8-B71B-0B557C5D33E45D9D.jpg""
        }
      ],
      ""weatherInfo"": ""With over 680 miles of land and water trails and hundreds of historical sites, there is a wide variety in weather. Please check with your favorite weather website before traveling."",
      ""name"": ""Washington-Rochambeau Revolutionary Route"",
      ""designation"": ""National Historic Trail"",
      ""multimedia"": [],
      ""relevanceScore"": 1
    }
  ]
}";

        [Fact]
        public void ParseCoordinates()
        {
            JsonDocument jd = JsonDocument.Parse(Cities);
            JsonElement root = jd.RootElement;
            var waltham = root.EnumerateArray()
                .FirstOrDefault(x => x.GetProperty("name").GetString().Equals("Waltham") && x.GetProperty("state").GetString().Equals("Massachusetts"));

            double latitude = waltham.GetProperty("latitude").GetDouble();
            Assert.Equal(42.3756401, latitude);
            double longitude = waltham.GetProperty("longitude").GetDouble();
            Assert.Equal(-71.2358004, longitude);
        }

        [Fact]
        public void EmptyCity()
        {
            JsonDocument jd = JsonDocument.Parse(Cities);
            JsonElement root = jd.RootElement;
            var waltham = root.EnumerateArray()
                .FirstOrDefault(x => x.GetProperty("name").GetString().Equals("WRONG") && x.GetProperty("state").GetString().Equals("Massachusetts"));

            Assert.Equal(JsonValueKind.Undefined, waltham.ValueKind);
        }

        [Fact]
        public void ParseParks() 
        {
            JsonDocument jd = JsonDocument.Parse(Parks);
            JsonElement data = jd.RootElement.GetProperty("data");
            var parks = new List<(string, string, string, string, double, double)>();
            foreach (JsonElement park in data.EnumerateArray())
            {
                string code = park.GetProperty("parkCode").GetString();
                string name = park.GetProperty("fullName").GetString();
                string url = park.GetProperty("url").GetString();
                string description = park.GetProperty("description").GetString();
                double latitude = Convert.ToDouble(park.GetProperty("latitude").GetString());
                double longitude = Convert.ToDouble(park.GetProperty("longitude").GetString());

                parks.Add((code, name, url, description, latitude, longitude));
            }

            Assert.Equal(18, parks.Count);
        }
    }
}