# 버튼 잡기 게임 ( C# 코딩 )

## 개요
- 핵심기능 : 버튼 위로 커서가 올라갈 경우 버튼의 위치를 랜덤한 위치로 이동시킴, 버튼이 도망갈 시 소리 재생,
  버튼을 클릭 시 소리 재생, 버튼의 크기가 점점 작아짐, 20번 이상 버튼 이동시 게임 오버 및 총 점수 표시 및 초기화.
 
- 화면구성 : 버튼, 버튼의 현재 픽셀 위치, 버튼 클릭 성공시 "축하합니다" 메세지 띄움, 다시하기, 총 점수
  
  
## 목표
 <1단계> - 기본 도망 기능
 
 <2단계> - 시각적/청각적 피드백
 
 <3단계> - 점수 표시와 점수별 난이도 조정
 
 <4단계> - 게임 오버 및 리셋
 
 ## 실행 화면
- 1단계 코드의 실행 스크린샷
<img width="1063" height="540" alt="catchme" src="https://github.com/user-attachments/assets/50510117-3e47-4a20-b736-ff5ca3a888f0" />
<img width="1163" height="561" alt="catchme2" src="https://github.com/user-attachments/assets/55b6b3c3-a654-458b-a1c3-439e6b87f807" />

- 2단계 코드의 실행 스크린샷
<img width="968" height="585" alt="catchme3" src="https://github.com/user-attachments/assets/2a1b5634-e5aa-407c-8141-792a68debbf7" />
https://github.com/user-attachments/assets/752f0c1f-c63f-4240-881f-a750aa17d908 << 실행영상


- 3단계 코드의 실행 스크린샷
<img width="801" height="481" alt="image" src="https://github.com/user-attachments/assets/57537679-8e05-4afd-993b-96e25b807495" />
<img width="797" height="479" alt="image" src="https://github.com/user-attachments/assets/8d45a2a0-7cf4-4a31-b54e-3eab5d62a83f" />

https://github.com/user-attachments/assets/30d30b90-a954-4e08-866b-9eed0d58f817 << 실행영상

- 4단계 코드의 실행 스크린샷
<img width="798" height="481" alt="image" src="https://github.com/user-attachments/assets/e289f980-4c7f-46f9-8fe5-1c4842cdc8d0" />


https://github.com/user-attachments/assets/51264240-96c0-413d-b779-25a10e26ccf6 << 실행영상


## 구현 시 어려웠던 점
- 1단계 코드를 작성할 때 버튼이 화면 밖으로 벗어나는 문제가 있었고, 이를 버튼의 크기를 고려하는 방식을 떠올려 해결함.
 
- 2단계 코드에서 효과음을 재생시키는 과정을 진행하던 중, 오류가 발생해 이를 Gemini 에게 질문하여 효과음으로 넣어둔 .wav 파일을 
  리소스 도구가 단순한 byte 데이터로 분류해 재생할 수 없었다는 것을 알았고, 이를 SoundPlayer 가 읽을 수 있도록 연결해 주는 코드를 작성해 해결함.
  
- 3단계 코드에서 버튼의 크기를 줄일 때 버튼의 크기는 10% 씩 줄어들었지만 폰트는 줄어들지 않아 크기가 맞지 않았음. 폰트 또한 같은 방법으로 크기를 줄이려했지만 데이터 타입 오류가 생겼고 이를 FontNewSize 라는 변수를 별도로 지정해 해결함.
  
- 4단계 코드에서 버튼을 보이지 않도록 하는 방법이 무엇인지 Gemini 에게 질문하여 visible, Enabled 이라는 옵션이 있다는 것을 알게 되었고 이를 수정하여 코드를 완성함.
