// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""91be1cb7-2d73-41de-973c-dd3408b24e69"",
            ""actions"": [
                {
                    ""name"": ""SelectLeft"",
                    ""type"": ""Button"",
                    ""id"": ""190bf3f6-5da4-4648-93ba-6d3be89a28f0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectRight"",
                    ""type"": ""Button"",
                    ""id"": ""667fdbad-a090-4c5c-a6df-5530087370a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ready"",
                    ""type"": ""Button"",
                    ""id"": ""53e612c1-0601-4054-ac24-e6e93f903e8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CancelReady"",
                    ""type"": ""Button"",
                    ""id"": ""8204aa75-331f-4199-87ff-b698e14085e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NextCategory"",
                    ""type"": ""Button"",
                    ""id"": ""a0e71a08-2715-4f7d-a940-79095ede044c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PreviousCategory"",
                    ""type"": ""Button"",
                    ""id"": ""8be45e2f-f605-46fa-b332-956ccdc474b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c386c840-9381-499a-b1f8-58f3ba179246"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ready"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb58da2b-ed4c-4a83-8058-27affbc5787d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ready"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63a03756-d124-4ab3-9e9e-fde29c36a6cb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d40fe991-d7e7-4347-a69d-1899e082404f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53d77b97-8626-4171-8b55-b8a679c3013d"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0315432a-371b-4f57-a20a-417d39808b7b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01b5695b-c20c-4aed-ad2b-dedd2da205a7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4428d9d3-53ea-49be-9368-e4dde29bc5f4"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8036f333-d1b1-4b33-b17f-c51e07c5969e"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CancelReady"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48395dbf-d7f0-4858-8fdb-0d89f8ca7a95"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CancelReady"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db7968a7-fedf-4db6-835d-c8f2f229d5a3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextCategory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2174f60-3a27-41e3-b26c-77eaf5496b1a"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextCategory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a312f171-f4c4-4ef7-90bf-dfd0c67787a6"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousCategory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5994747d-89c4-4e56-859a-8eb99118a607"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PreviousCategory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InGame"",
            ""id"": ""0267c24a-512a-4592-830d-353480d1ce3e"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0cb08432-2b55-41f5-91fa-8ed2557eb454"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""a7118b60-ccad-480a-bf37-4c28af46f676"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Guard"",
                    ""type"": ""Button"",
                    ""id"": ""0f806628-c8e4-4041-af7e-f4c4867e3572"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""HeavyAttack"",
                    ""type"": ""Button"",
                    ""id"": ""baf0c326-61a8-495b-8b31-e2195a2f8d0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""SpecialAttack"",
                    ""type"": ""Button"",
                    ""id"": ""c34befb2-a273-4623-990b-c4da01ea04be"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""wsad"",
                    ""id"": ""1ee952ec-67e1-47d4-93a8-2aaf46151ed7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""732000b1-3776-44c9-9337-90197fdd7ada"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""17dfbb51-3ada-4c2b-bd7f-2dd69550c8d0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8fc11100-2ab1-47c7-95c4-2a2262dca322"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ebb1f7bb-5faa-4720-8b22-e80a9f8ed157"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepad"",
                    ""id"": ""75200cab-36b6-464b-9de7-fe4264000e95"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""36343845-8c07-455b-af69-36ef363bd847"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ad755b8e-ae9a-4f96-a74e-e1a9d1746fa6"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4889db46-10a0-478a-996a-bcbe035ff96c"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""28a782ee-0f17-4404-ac0b-fef47a8e05f1"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b03a156a-b481-4d23-9889-220711b409af"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e2807fe-61ce-49ec-ba21-ff8070319f8d"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f14c1cad-3f37-4073-af66-2977c9eed1f7"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""caa26950-71e7-4568-9fc9-751e23eb86b1"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef4e0e2d-0fe7-4c55-a111-9fd89c349205"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavyAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60997f46-d8db-4354-b92a-267fafdc04f1"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HeavyAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26b4a1b0-c33d-41cf-a22c-e3d925cdba84"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e4169f6-bf5d-4048-8abf-6dc25a6f166e"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_SelectLeft = m_Menu.FindAction("SelectLeft", throwIfNotFound: true);
        m_Menu_SelectRight = m_Menu.FindAction("SelectRight", throwIfNotFound: true);
        m_Menu_Ready = m_Menu.FindAction("Ready", throwIfNotFound: true);
        m_Menu_CancelReady = m_Menu.FindAction("CancelReady", throwIfNotFound: true);
        m_Menu_NextCategory = m_Menu.FindAction("NextCategory", throwIfNotFound: true);
        m_Menu_PreviousCategory = m_Menu.FindAction("PreviousCategory", throwIfNotFound: true);
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_Movement = m_InGame.FindAction("Movement", throwIfNotFound: true);
        m_InGame_Attack = m_InGame.FindAction("Attack", throwIfNotFound: true);
        m_InGame_Guard = m_InGame.FindAction("Guard", throwIfNotFound: true);
        m_InGame_HeavyAttack = m_InGame.FindAction("HeavyAttack", throwIfNotFound: true);
        m_InGame_SpecialAttack = m_InGame.FindAction("SpecialAttack", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_SelectLeft;
    private readonly InputAction m_Menu_SelectRight;
    private readonly InputAction m_Menu_Ready;
    private readonly InputAction m_Menu_CancelReady;
    private readonly InputAction m_Menu_NextCategory;
    private readonly InputAction m_Menu_PreviousCategory;
    public struct MenuActions
    {
        private @Controls m_Wrapper;
        public MenuActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SelectLeft => m_Wrapper.m_Menu_SelectLeft;
        public InputAction @SelectRight => m_Wrapper.m_Menu_SelectRight;
        public InputAction @Ready => m_Wrapper.m_Menu_Ready;
        public InputAction @CancelReady => m_Wrapper.m_Menu_CancelReady;
        public InputAction @NextCategory => m_Wrapper.m_Menu_NextCategory;
        public InputAction @PreviousCategory => m_Wrapper.m_Menu_PreviousCategory;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @SelectLeft.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectLeft;
                @SelectLeft.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectLeft;
                @SelectLeft.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectLeft;
                @SelectRight.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectRight;
                @SelectRight.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectRight;
                @SelectRight.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnSelectRight;
                @Ready.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnReady;
                @Ready.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnReady;
                @Ready.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnReady;
                @CancelReady.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancelReady;
                @CancelReady.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancelReady;
                @CancelReady.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnCancelReady;
                @NextCategory.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNextCategory;
                @NextCategory.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNextCategory;
                @NextCategory.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNextCategory;
                @PreviousCategory.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPreviousCategory;
                @PreviousCategory.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPreviousCategory;
                @PreviousCategory.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPreviousCategory;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SelectLeft.started += instance.OnSelectLeft;
                @SelectLeft.performed += instance.OnSelectLeft;
                @SelectLeft.canceled += instance.OnSelectLeft;
                @SelectRight.started += instance.OnSelectRight;
                @SelectRight.performed += instance.OnSelectRight;
                @SelectRight.canceled += instance.OnSelectRight;
                @Ready.started += instance.OnReady;
                @Ready.performed += instance.OnReady;
                @Ready.canceled += instance.OnReady;
                @CancelReady.started += instance.OnCancelReady;
                @CancelReady.performed += instance.OnCancelReady;
                @CancelReady.canceled += instance.OnCancelReady;
                @NextCategory.started += instance.OnNextCategory;
                @NextCategory.performed += instance.OnNextCategory;
                @NextCategory.canceled += instance.OnNextCategory;
                @PreviousCategory.started += instance.OnPreviousCategory;
                @PreviousCategory.performed += instance.OnPreviousCategory;
                @PreviousCategory.canceled += instance.OnPreviousCategory;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // InGame
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_Movement;
    private readonly InputAction m_InGame_Attack;
    private readonly InputAction m_InGame_Guard;
    private readonly InputAction m_InGame_HeavyAttack;
    private readonly InputAction m_InGame_SpecialAttack;
    public struct InGameActions
    {
        private @Controls m_Wrapper;
        public InGameActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_InGame_Movement;
        public InputAction @Attack => m_Wrapper.m_InGame_Attack;
        public InputAction @Guard => m_Wrapper.m_InGame_Guard;
        public InputAction @HeavyAttack => m_Wrapper.m_InGame_HeavyAttack;
        public InputAction @SpecialAttack => m_Wrapper.m_InGame_SpecialAttack;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnMovement;
                @Attack.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnAttack;
                @Guard.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnGuard;
                @Guard.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnGuard;
                @Guard.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnGuard;
                @HeavyAttack.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnHeavyAttack;
                @HeavyAttack.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnHeavyAttack;
                @HeavyAttack.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnHeavyAttack;
                @SpecialAttack.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnSpecialAttack;
                @SpecialAttack.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnSpecialAttack;
                @SpecialAttack.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnSpecialAttack;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Guard.started += instance.OnGuard;
                @Guard.performed += instance.OnGuard;
                @Guard.canceled += instance.OnGuard;
                @HeavyAttack.started += instance.OnHeavyAttack;
                @HeavyAttack.performed += instance.OnHeavyAttack;
                @HeavyAttack.canceled += instance.OnHeavyAttack;
                @SpecialAttack.started += instance.OnSpecialAttack;
                @SpecialAttack.performed += instance.OnSpecialAttack;
                @SpecialAttack.canceled += instance.OnSpecialAttack;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);
    public interface IMenuActions
    {
        void OnSelectLeft(InputAction.CallbackContext context);
        void OnSelectRight(InputAction.CallbackContext context);
        void OnReady(InputAction.CallbackContext context);
        void OnCancelReady(InputAction.CallbackContext context);
        void OnNextCategory(InputAction.CallbackContext context);
        void OnPreviousCategory(InputAction.CallbackContext context);
    }
    public interface IInGameActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnGuard(InputAction.CallbackContext context);
        void OnHeavyAttack(InputAction.CallbackContext context);
        void OnSpecialAttack(InputAction.CallbackContext context);
    }
}
