Build an example WebAPI that invokes 2 other WebAPIs
Calls should occur from the front-end WebAPI to the 2 back-end APIs in an Asynchronous manner
Artificial delays can be introduced to mimic a longer running operation in API2 and API3
Front-end Web API to support Get/Post verbs
Be prepared to discuss options to secure front-end API

# Code Analysis
When implementing the API and working with external APIs, first we need to answer following questions:
- Performance considerations. What are our expectations from the performance? What should we expect from the external API?
- Error processing on our and their side; using HTTP codes and providing additional information;
- Logging;
- Rate limiting;
- Security;
# Sample Application
We'll create a simple Web API which will return a 3 national parks closest to certain US city. It will accept the city name and state code as parameters and return a list of park names and urls, location and the distance to the park.
We will use 2 external APIs:
- Api Ninja (https://api-ninjas.com/) geolocation to retrieve the town coordinates;
- NPS API (https://developer.nps.gov/) - to retrieve the list of the parks.
Having city and parks coordinates, we can calculate the distance etc.
- For simplicity, we will hardcode API keys in the code.

# To Be Discussed
- [ ] Post vs Get. Currently, all API calls uses GET. Using POST is possible;
- [ ] Security. Additional measures to secure our own API. API keys are used to access the external API. CORS policy. Using JWT tokens.
- [ ] Rate limiting, delays. Processing 429 code. To call the external APIs asynchronous calls are used. The calls are sequential, but since they're not depend on each other the call may be performed simultaneously. Also we need to consider using rate limiting for our API.
- [ ] Error processing. Different approaches for informing users.
