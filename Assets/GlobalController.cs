using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalController : MonoBehaviour
{

    public GameObject cube;
    public GameObject sphere;
    public GameObject cylinder;
    public GameObject capsule;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // all three primitives have a Collider by default


        
        // the cube has no additional components. it has no physics, so it will float in space.



        // the sphere has an added Rigidbody component, with default settings. it has physics, and will begin to fall at game start. when it collides with other objects, they interact. note how the black demonstration cylinder is knocked over and the ball continues to roll.



        // the cylinder has an added Rigidboy component, with "is kinematic" enabled. it if frozen in place unless moved via scripting. it is not affected by outside forces (eg gravity, or things hitting it), but other objects do still collide with it. note how the black demonstration sphere falls until it collides, but the cylinder is unperturbed.



        // the capsule has an added Rigidbody component, with default settings. its Collider component has "is trigger" enabled. it has physics, and will fall. however, collision physics are disabled and it will fall through the ground (and any other objects). collisions will still trigger an event, but it's path will not be affected; it will phase through other objects.
    }
}
