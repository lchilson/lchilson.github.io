Talking Points



### Architects and the Architecture Domain - talk 2

Any architect of any title can fall into one of these groups

**TALKING POINT** this is opinion





## Pain of architecture
Everything is movig so fast technology. Everyone has a pain point they can recall.
.Net core 1 to 2..then to 2.1...and2.2 and then finally...3.1. Slightly painful upgrades

Angualrjs to angualr? Heck Angualr 1-8 i cant recall an upgrade that didnt invlve a code change.

maybe next.js? the breaks dont just happen in nextjs lib. you have to account for node versions npm and react at its base not even gonna think about packages.. same issue as angualr.. nightmares..

maybe we can all recall the reasons we know have a package version manager for a packag manager.....

if you didnt know you can just pretend you never heard something like this before
 nvm npm

**TALKING POINT s** 
1. **Container Breakouts:** Initially, Docker containers weren't as isolated as virtual machines. This led to concerns about a process inside a container potentially breaking out and gaining access to the host system or other containers. This was a significant risk, especially in multi-tenant environments where different users' containers might be running on the same host.

2. **Kernel Exploits:** Docker containers share the host's kernel. Any vulnerabilities in the host's kernel could potentially be exploited by a malicious container to gain elevated privileges. This was particularly concerning because any exploit that affected the kernel could impact all containers on the host.

3. **Image Security:** Early on, Docker did not have robust mechanisms for ensuring the integrity and authenticity of container images. This raised the possibility of pulling and running malicious images from Docker registries, whether inadvertently or through targeted attacks.

4. **Docker Daemon API Security:** The Docker daemon runs with root privileges, and early versions of Docker had less stringent controls over who could access the Docker API. Unauthorized access to this API could lead to a wide range of security breaches.

5. **Network Security:** Network configuration and isolation were also areas of concern. In the early stages, Docker's default networking modes could inadvertently expose container services or lead to insufficient network isolation between containers.

6. **Resource Limitation:** Without proper resource limitations, a container could potentially consume excessive system resources, leading to denial-of-service (DoS) on the host system or affecting other containers.

7. **Secret Management:** Early Docker did not have a built-in mechanism for secret management, which made it challenging to securely store and manage sensitive information like passwords and API keys within containers.

8. **Logging and Auditing:** Initially, Docker lacked comprehensive logging and auditing features, making it harder to track unauthorized or malicious activities within containers.

Over time, Docker and the container ecosystem have evolved significantly to address these and other security concerns. Features like enhanced container isolation, improved image signing and verification, more secure network configurations, resource limits, and better auditing and logging capabilities have greatly improved Docker's security posture.


**Where They Shine: Risk Management**  
Beyond just technical stack considerations, Architects have a broad skill set that allows them to understand how new service components might impact the system as a whole. They excel in scenarios where there's a need to anticipate and mitigate risks, such as adding new features that might overload a database server. For instance, they can foresee the implications of a new system performing mass updates during another system's critical processes, allowing for better risk mitigation.

#### Types of Architects
While titles may vary across companies, the roles of architects generally fall into similar categories.

The distinction between an architect who codes and one who doesn't is significant in the tech industry, each bringing unique strengths and facing different challenges. Here's a comparison of the two:
### Architect Who Doesn't Code

**Strengths**:
1. **Broad Strategic Focus**: They often have a broader view, focusing on strategy, planning, and overall system design.
2. **Risk Management**: They might be better at identifying and mitigating risks that are not purely technical.
3. **Client-Focused Solutions**: Their solutions can be more aligned with client needs and business goals.
4. **Cross-Disciplinary Knowledge**: They often possess a wider range of knowledge across various domains.

**Challenges**:
1. **Technical Communication Gap**: There may be a communication gap with the development team due to a lack of technical expertise.
2. **Keeping Up with Tech Trends**: Staying informed about the latest technologies can be more challenging without hands-on experience.
3. **Risk of Unrealistic Designs**: They might design systems or features without fully understanding the technical limitations or complexities.

### Architect Who Codes

**Strengths**:
1. **Technical Expertise**: They have hands-on experience with coding, which helps in understanding the practical aspects of implementing a design.
2. **Problem-Solving**: Their coding experience enables them to foresee and solve technical problems more effectively.
3. **Communication with Developers**: They can communicate more efficiently with the development team, as they speak the same technical language.
4. **Keeping Skills Up-to-Date**: They are more likely to be updated with the latest programming trends and technologies.
5. **Practical Solutions**: Their solutions are often more grounded in what is technically feasible.

**Challenges**:
1. **Risk of Getting Too Involved in Details**: They might get too caught up in coding details, losing sight of the broader strategic goals.
2. **Balancing Time**: Finding the right balance between architectural responsibilities and coding can be challenging.
3. **Biased Towards Familiar Technologies**: They might favor solutions based on their coding experience rather than exploring new or different technologies.



### Conclusion
Both types of architects play vital roles in the tech industry. Architects who code bring valuable technical insight and practicality to the table, while those who don’t code excel in strategic planning and broad vision. The choice between the two depends on the specific needs of the project, the team composition, and the overall goals of the organization. Often, a balance between both types of architects leads to the most effective and innovative solutions.