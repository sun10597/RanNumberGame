# 🎲 C# WinForms 숫자 맞추기 Up & Down 게임

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white) 
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge&logo=windows&logoColor=white)

## 🌟 프로젝트 소개
C# 언어와 Windows Forms를 활용하여 만든 간단한 **숫자 맞추기 Up & Down 게임**입니다.

이 프로젝트는 C#의 기본적인 문법(조건문, 랜덤 함수, 데이터 타입 변환)을 학습하고, GUI 환경에서 **이벤트 처리 방식**을 익히기 위해 제작되었습니다.

## ✨ 주요 기능
1.  **랜덤 숫자 생성:** 1부터 50까지의 무작위 숫자를 컴퓨터가 설정합니다.
2.  **기회 제한:** 플레이어에게 총 5번의 시도 기회를 제공합니다.
3.  **직관적인 피드백:** 입력값에 따라 `UP` (더 큰 수) 또는 `DOWN` (더 작은 수) 메시지를 화면 중앙에 즉시 표시합니다.
4.  **게임 상태 관리:** 정답을 맞히거나 기회를 모두 사용하면 자동으로 게임 상태와 시도 횟수를 초기화합니다.
5.  **입력값 검증:** 사용자가 숫자가 아닌 값을 입력했을 경우 경고 메시지를 출력합니다.

## 🖼️ 실행 화면
<img width="790" height="389" alt="image" src="https://github.com/user-attachments/assets/f4f798c4-1db0-4ca1-845f-75cfb2543b77" />

## 💻 사용 기술
* **언어:** C#
* **프레임워크:** .NET (Windows Forms)
* **개발 환경:** Visual Studio

## 🚀 시작하는 방법
1.  **저장소 클론:**
    ```bash
    git clone [https://github.com/sun10597/RanNumberGame.git](https://github.com/sun10597/RanNumberGame.git)
    ```
2.  **프로젝트 열기:** Visual Studio를 열고 프로젝트 폴더 내의 `.sln` 파일을 엽니다.
3.  **실행:** Visual Studio에서 `F5` 키를 눌러 디버깅 모드로 실행합니다.

## 📌 향후 개선 계획
* **난이도 설정 기능:** 게임 시작 전 1-50, 1-100 등 난이도를 선택할 수 있도록 추가.
* **기록 리스트 (History Log):** 시도한 횟수와 힌트 기록을 화면에 표시하여 게임의 편의성 개선.
