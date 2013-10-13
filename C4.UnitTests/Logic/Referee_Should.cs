using C4.Logic;
using C4.Model;
using NUnit.Framework;

namespace C4.Tests_Unit.Logic
{
    [TestFixture]
    public class Referee_Should
    {
        #region Row 5

        [Test]
        public void HasFourInARowHorizontal_Index_5_0_To_5_3()  //[.][.][.][.][][][]
        {
            var gameboard = GameBoard.GetGameInstance();
            var sut = new Referee(gameboard);
            gameboard.TakeMove(xDim: 0);
            gameboard.TakeMove(xDim: 1);
            gameboard.TakeMove(xDim: 2);
            gameboard.TakeMove(xDim: 3);

            sut.Has4InARowHorizontal(GameToken.Red);
        }

        [Test]
        public void HasFourInARowHorizontal_Index_5_1_To_5_4()  //[][.][.][.][.][][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_5_2_To_5_5()  //[][][.][.][.][.][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_5_3_To_5_6()  //[][][][.][.][.][.]
        {

        }

        #endregion

        #region Row 4

        [Test]
        public void HasFourInARowHorizontal_Index_4_0_To_4_3()  //[.][.][.][.][][][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_4_1_To_4_4()  //[][.][.][.][.][][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_4_2_To_4_5()  //[][][.][.][.][.][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_4_3_To_4_6()  //[][][][.][.][.][.]
        {

        }

        #endregion

        #region Row 3

        [Test]
        public void HasFourInARowHorizontal_Index_3_0_To_3_3()  //[.][.][.][.][][][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_3_1_To_3_4()  //[][.][.][.][.][][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_3_2_To_3_5()  //[][][.][.][.][.][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_3_3_To_3_6()  //[][][][.][.][.][.]
        {

        }

        #endregion

        #region Row 2

        [Test]
        public void HasFourInARowHorizontal_Index_2_0_To_2_3()  //[.][.][.][.][][][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_2_1_To_2_4()  //[][.][.][.][.][][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_2_2_To_2_5()  //[][][.][.][.][.][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_2_3_To_2_6()  //[][][][.][.][.][.]
        {

        }

        #endregion

        #region Row 1

        [Test]
        public void HasFourInARowHorizontal_Index_1_0_To_1_3()  //[.][.][.][.][][][]
        {
            
        }

        [Test]
        public void HasFourInARowHorizontal_Index_1_1_To_1_4()  //[][.][.][.][.][][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_1_2_To_1_5()  //[][][.][.][.][.][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_1_3_To_1_6()  //[][][][.][.][.][.]
        {

        }

        #endregion

        #region Row 0

        [Test]
        public void HasFourInARowHorizontal_Index_0_0_To_0_3()  //[.][.][.][.][][][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_0_1_To_0_4()  //[][.][.][.][.][][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_0_2_To_0_5()  //[][][.][.][.][.][]
        {

        }

        [Test]
        public void HasFourInARowHorizontal_Index_0_3_To_0_6()  //[][][][.][.][.][.]
        {

        }

        #endregion
    }   
}
