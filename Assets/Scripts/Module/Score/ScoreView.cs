using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using TMPro;

namespace SpaceInvader.Module.Score
{
    public class ScoreView : ObjectView<IScoreModel>
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        
        protected override void InitRenderModel(IScoreModel model)
        {
            scoreText.text =$"Score: {model.score.ToString()}";
        }

        protected override void UpdateRenderModel(IScoreModel model)
        {
            scoreText.text = $"Score: {model.score.ToString()}";
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
