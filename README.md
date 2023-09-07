# 1week

씬구분 : MainMenu , MainScene

# MainMenu

SoundManager : 오디오 클립을 가지고 있어 버튼 클릭 시 효과음 출력 / 씬 전환 시 소리가 재생이 되다가 멈추는걸 고려해  DontDestroyOnLoad 사용해 소리가 끊기지 않게함

Input Field : 사용자의 입력을 받고 PlayerPrefs의 "Name"이라는 이름의 변수 저장

MainCamera : 오디오 클립을 가지고 있어 배경 음악 재생

# MainScene

Prefabs : Player의 정보를 가지고있는 개체로 씬 전환 시 생성됨

GamaManager : 씬 전환 시 Name 변수를 불러와서 Prefabs로 생성된 Player를 찾아서 Text에 전달함 그후 개체 생성

CameraController : Prefabs안에 같이 카메라를 넣어두고 오브젝트와 같이 생성되며 Target이라는 오브젝트를 스크립트로 따라다니게함

Animator : Player의 InputValue로 전달되는 Vector2의 근거해 -1, 0, 1 라는 값에 가까울 수록 해당 값에 가까운 애니메이션이 재생됨 , 키보드로 좌우 반전 재생

효과음 : Animator의 IsMoving에 접근해 해당 변수가 True라면 Move.cs의 Update()를 통해 오디오 클립 재생


           
