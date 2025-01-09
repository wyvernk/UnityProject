# AR PhysioLab

## 👨‍💻 Problem Statement:
In higher education institutions, there are many students that are enrolled, but the amount of resources provided may not be enough to cater to these students. This is prevalent in physiotherapy courses as the course requires physical tools and equipment that are limited in number for students to practice their craft. This can result in students feeling underprepared for their tests and examinations as they do not have enough practice with the physical equipment. The physical equipment is also only available on campuses, and they are expensive to purchase.

## Needfinding Method:
### 1) Focus Group
- A focus group was conducted on 13 September 2023 with 5 participants, with an age ranging from 20 to 25 years old. The questions focused on understanding the challenges faced in higher education. We would like to improve the learning process of physiotherapy students to help them better prepare for their assignments and exams. It was found that during their exam periods, there was not enough equipment for them, which resulted in long waiting times.  
![image](https://github.com/user-attachments/assets/1e40d31d-65e3-4c55-9ae5-a1044c4cd1ff)

### 2) Online Survey
- A survey was conducted from 16 September 2023 to 19 September 2023, with 31 responses, and an age range of 20 to 25 years old. The questions focused on understanding the education experience of SIT Physiotherapy students to improve their learning process and help them better prepare for their assignments and exams. It was found that especially during exam periods, students experienced long waiting times for equipment such as plinths, pillows and pillow covers, and skeletons necessary for them to practice for their exams. Additionally, there were no existing scheduling methods to help combat this.

---

## Chosen Idea:
**Augmented Reality (AR) physiotherapy application**  
- AR provides a visual, interactive, and immersive environment for the user to practice their skills. Due to its interactive and immersive properties, it will help students memorize their procedures when conducting their lessons. Since it is also easily accessible, all students will be able to use it and will not have to rely on the plinth bed availability to practice their skills. Based on our user needs and requirements, AR would allow students to have more practice for their exams. As stated previously, it helps students memorize effectively, and AR is an interactive learning tool that satisfies the user's needs.

---

## Low Fidelity Prototype:
- The Prototype Video is made to help understand the full flow. It is located in the same GitHub folder named **“lofi”**. It is also available on [YouTube](https://youtu.be/YlqpJZwEBHg).  
![image](https://github.com/user-attachments/assets/5217a697-4ed4-4d56-9a7f-709d270bc60d)

---

## Testing:
### 1) Heuristic Evaluation
- A heuristic evaluation was conducted on 12 October 2023 with Group 13. We showcased a video to the evaluators that showed how physiotherapy students from SIT would conduct their practicals so that they would have some knowledge of the task they needed to perform. After that, we conducted the evaluation with our paper prototype.

| Heuristic                                 | Severity Rating | Description and Possible Solutions                                                                 |
|-------------------------------------------|-----------------|---------------------------------------------------------------------------------------------------|
| **Visibility of system status**           | 1               | Unable to see past submissions                                                                   |
| **Match between system and the real world** | 0               | Buttons intuitively mapped                                                                       |
| **User control and freedom**              | 1               | No way to go back to home screen from scanning screen                                            |
| **Consistency and standards**             | 0               | Smooth flow in UI                                                                                |
| **Error prevention**                      | 2               | No confirmation message if the wrong body part is clicked on by the user, no error prevention for using the wrong tool |
| **Recognition rather than recall**        | 0               | Smooth and intuitive GUI                                                                         |
| **Flexibility and efficiency of use**     | 1               | For instructions, you can use diagrams instead of words for better efficiency                   |
| **Aesthetic and minimalist**              | 1               | Instructions can be reduced to point form                                                       |
| **Help users recognize, diagnose, and recover from errors** | 2 | No way for users to know if they make an error, and no hints for the user if they are lost       |
| **Help and documentation**                | 2               | No instructions aside from the instruction page, no instructions on how to use tools, etc.       |

---

### 2) Think-aloud Evaluation
- A think-aloud evaluation was conducted on 12 October 2023 with Group 29. Firstly, we read the usability script to them and got their consent to perform the evaluation. We then conducted the evaluation where each individual had to complete the tasks assigned while speaking out their thoughts.

---

## Conclusion of the Testing
### 1) Heuristic Evaluation
- From the heuristic evaluation, we realized that we were lacking a back button in many scenarios. Our instruction page is also too wordy, not easily accessible, and there is no alternative way for users to understand how to use the application. We also did not have sufficient feedback, as users are currently unable to tell if they are using the wrong tool, and there are no hints to tell the user if what they are doing is correct or incorrect. Lastly, there is no way for users to have a look at their past diagnosis attempts, which can be helpful for reflection.

### 2) Think-aloud Evaluation
- From the think-aloud evaluation, we found out there are a lot of problems with the instructions page and finding out the patient’s condition. Similar to our heuristic evaluation, users feedbacked that the instruction page was too wordy and was only accessible from the menu, causing them to get lost when they started the diagnosis as they forgot the instructions and could no longer access them. Some users are also not familiar with the AR plane finding functionality and do not know what it means when they are required to look for a smooth surface to start diagnosing the patient. When told to find the patient diagnosis, our user interface was not clear enough, and users took a long time to find where it was located. Users are also not familiar with interacting with AR objects and did not know how to use the tools they selected to interact with the augmented patient. Similar to the heuristic evaluation, they also did not know if the tool they were using was being used correctly. Lastly, the notes they noted down could have been put to better use, as users thought that the notes would have been reflected on the findings submission pages, but they were not.

---

## Implementation:
- **Unity engine**: Easy to pick up with many libraries and APIs that we could use to help with project implementation.  
- **Vuforia AR engine**: Easy to pick up as an AR engine and has functionalities required for the project.

### Implementation Plan:

| **Task**                                                      | **Components/Dependencies**   | **Done by** | **Due Date** |
|---------------------------------------------------------------|--------------------------------|-------------|--------------|
| Setup project base                                            | Unity engine, Vuforia AR engine | Wyvern      | 17/10/23     |
| Create main menu                                              | Unity engine                   | Den         | 19/10/23     |
| Create and implement button functionality for posture and tools | Unity engine, Vuforia AR engine | Wyvern      | 20/10/23     |
| Create and implement button functionality for reviewing of diagnosis | Unity engine                   | Wyvern      | 22/10/23     |
| Create and implement button functionality for patient condition | Unity engine                   | Brendan     | 24/10/23     |
| Create and implement functionality for text box for user feedback when interacting with patient | Unity engine, Vuforia AR engine | Den         | 26/10/23     |
| Create Instruction page and inputting instruction list        | Unity engine                   | Hakim       | 17/10/23     |
| Creating the interface of the scanning screen                | Unity engine                   | Jess        | 19/10/23     |
| Create the AR plinth bed and patient                         | Unity engine                   | Wyvern      | 18/10/23     |
| Make the AR plinth bed and patient appear on the scanning screen upon detecting a smooth surface | Unity engine, Vuforia AR engine | Wyvern      | 20/10/23     |
| Create the Note Taking page                                  | Unity engine                   | Brendan     | 21/10/23     |
| Create UI sprites for buttons                                | Unity engine                   | Zining      | 19/10/23     |

---

## Result:
- This is the [YouTube link](https://youtu.be/wX21M9F2J64?feature=shared) to our final product demo.
![image](https://github.com/user-attachments/assets/339dcaa3-fae8-4f0c-963f-d2630dbb7c6d)
![image](https://github.com/user-attachments/assets/317c6336-b1a9-4b8a-97ae-617090650673)
![image](https://github.com/user-attachments/assets/a4e56c52-b1b3-4e07-9c1a-f11fcdf84f24)



