### Research & Planning
#### Sunday 09/17/2023

* 10 am: research best languages to write this in.
* 11 am: start the proposal.
* 11:30 am: Deciding MVP
* 12:30 pm: Looked more into what languages would be best for the messaging application.
https://www.techwebspace.com/a-comprehensive-guide-to-the-best-languages-to-build-a-chat-app/
https://www.cometchat.com/blog/best-programming-languages-to-build-chat
* 1 pm: Looking into wether I should use Golang vs Python, and React vs Vue.
* 1:53 pm: Still looking into languages to choose. Focusing on Vue vs React currently.
https://www.sitepoint.com/vue-vs-react/#:~:text=The%20main%20difference%20between%20Vue,extended%20as%20a%20project%20grows.
https://www.youtube.com/watch?v=Jk0smQXxd9k&ab_channel=StefanMischook
https://www.youtube.com/watch?v=N4T-78LOoN8&ab_channel=VueMastery
* 3 pm: Decided on Vue. Researching Golang vs Python. Also now wondering I should consider doing TypeScript instead of JavaScript.
https://www.interviewbit.com/blog/golang-vs-python/#:~:text=As%20Python%20is%20a%20scripting,it%20more%20readable%20and%20flexible.
https://softwareengineeringdaily.com/2021/03/03/why-we-switched-from-python-to-go/
https://hackr.io/blog/golang-vs-python
https://www.simplilearn.com/tutorials/golang-tutorial/golang-vs-python
https://www.bacancytechnology.com/blog/go-vs-python
* 3:20 pm: Still researching Golang vs Python. 
* 4:10 pm: Will be using Golang and JavaScript. Learning three new languages is quite ambitious.
* 4:25 pm: Working more on the proposal now that I know what languages I will be using.
* 5:05 pm: WIP capstone-proposal.md.
* 6:10 pm: Working on a physical outline for how the page should look.
* 6:55 pm: Completed "outline" of what the site will look like (hopefully). Looking at other dating sites to figure out some quiz questions.

#### Saturday 09/23/2023

* 12:39 pm: Reading https://softprodigy.com/a-step-by-step-guide-to-build-a-real-time-chat-app-with-vue-js-and-golang/ to figure out the best way to start the messaging tool in the application.
* 12:56 pm: Followed steps to start a Vue program and download golang to pc.
* 2 pm: Continuing reading materials on how to write the chat application. https://anupkumarpanwar.medium.com/realtime-chat-app-in-golang-a1e4e9d01fea
https://deadsimplechat.com/blog/golang-websocket-chat-server/
https://www.youtube.com/watch?v=y036l6pvVEs&ab_channel=EsotericTech
* 3:05 pm: Looking at the Go documentation https://go.dev/ and doing smaller code sets to get used to the syntax for golang https://gobyexample.com/.
* 4 pm: WIP documentation and syntax
* 5:05 pm: More information on Vue and JS. https://vuejs.org/guide/introduction.html https://developer.mozilla.org/en-US/docs/Web/JavaScript https://web.dev/responsive-web-design-basics/
* 5:41 Watching playlist https://www.youtube.com/watch?v=FyUCKxkCFAc&list=PLlameCF3cMEtP64u9VtbwYaviLCbnRsBA&ab_channel=ScalableScripts
* 6:27 pm: https://levelup.gitconnected.com/create-a-chat-application-in-golang-with-redis-and-reactjs-c75611717f84 https://www.geeksforgeeks.org/how-to-create-a-simple-javascript-quiz/
* 7:51 pm: Looking at more in-depth Vue.Js UI/UX libraries and ideas https://athemes.com/collections/vue-ui-component-libraries/ https://vue-community.org/guide/ecosystem/ui-libraries.html https://madewithvuejs.com/ui-library https://www.codeinwp.com/blog/vue-ui-component-libraries/#gref

#### Saturday 09/24/2023
* 6:04 pm: https://www.youtube.com/watch?v=R69i5dHdk2c&ab_channel=DennisBabych https://www.youtube.com/watch?v=x3lypVnJ0HM&ab_channel=MemeableData Researching best ways to "create" and maintain a dating website for both sexes and all genders. 
https://www.oasisconsortium.com/insights/making-safety-universal-in-online-dating-equal-inclusive-safe-rebuilding-online-dating https://rshare.library.torontomu.ca/articles/thesis/Inclusive_By_Design_Creating_A_Dating_App_Built_On_Inclusive_Design_Principles/14663181 https://aws.amazon.com/startups/learn/how-smore-is-building-an-inclusive-dating-app?lang=en-US
* 7:23 pm: Looking at more dating sites https://www.androidpolice.com/best-lgbtq-dating-apps/ https://smileymovement.org/news/best-inclusive-dating-apps/ https://mashable.com/roundup/best-dating-sites-for-introverts https://chicagoreader.com/reader-partners/twenty-best-lgbtq-dating-sites-and-apps/ https://www.bustle.com/life/best-queer-dating-apps

#### Sunday 10/01/2023
* 10:30 am: Created file structure and moving chat code to the current file structure. 
backend/: Contains the Golang backend code.

main.go: Entry point for the backend.
api/: Organizes the API code.
handlers/: Handles HTTP request handling.
middleware/: Middleware for authentication, logging, etc.
models/: Defines data models and database schema.
routes/: Defines API routes and routing logic.
utils/: Utility functions.
config/: Configuration files, e.g., environment variables.
static/: Static files, if needed (e.g., images, CSS).
frontend/: Contains the Vue.js frontend code.

src/: The main source directory for Vue.js.
assets/: Static assets like images and CSS.
components/: Reusable Vue.js components.
views/: Vue.js views or pages.
router/: Vue Router configuration.
store/: Vuex store modules for state management.
services/: Frontend services for API communication.
main.js: Vue.js entry point.
public/: Publicly accessible files.
dist/: Compiled Vue.js application (generated during build).
babel.config.js: Babel configuration for JavaScript transpilation.
package.json: Frontend dependencies and scripts.
vue.config.js: Vue.js configuration, e.g., proxy for API requests.

* 4:50 pm: WIP converting original chat code to new file structure.
* 6:48 pm: Switched to C# instead of Golang. Too much anxiety using a new language for a big project.
* 7 pm: Started working on Controllers for G2GClient
* 8 pm: WIP UserController.cs in G2GClient
* 8:35 pm: Started working on G2GClient Models.
* 9:20 pm: WIP ViewModels
* 10:10 pm: Random bug fixes 
* 11: pm: Finished View/Account HTML pages.

#### Monday 10/02/2023

* 6: pm: Working on View/ Home, Quiz, Shared, and Users.
* 6: 30 pm: Switched to G2GApi to remove errors. WIP Auth and Controllers.
* 8: 10 pm: WIP G2GApi

#### Tuesday 10/03/2023
* 8: am: Started Proof of Concept to show what the pages could look like. I don't believe I'll get the logic done in time, and I still want to be able to show something.
* 11: am: Started first HTML page.
* 1: pm: Creating G2G Logo(s)
* 2:53 pm: Finished two logos. One main, and one to be consistent through all pages.
* 3:20 pm: Finishing first profile.
* 4: pm: Decided to make profiles for Henry Cavill, Emma Watson, Vin Diesel, and Margot Robbie. Started creating quiz questions.
* 4:40 pm: Started on Vin's profile.
* 5:15 pm: Finished profiles. Searching for images.

#### Wednesday 10/04/2023

* 9: am: Connecting CSS sheet.
* 9: 30 am: Adding CSS.
* 10: 55 am: Completed Login css, adding css to other pages.
* 11: 40 am: Completed Registration page.
* 2: pm: Started working on Index page.
* 3: pm: WIP Index page.
* 4:30 pm: Fighting with CSS to center buttons.
* 5:35 pm: Threw hands long enough that the buttons are centered.
* 6: 10pm: WIP UI quiz.html
* 6: 40pm: minor bug fixes.